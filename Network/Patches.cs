using System.Linq;
using VRC.SDKBase;
using ExitGames.Client.Photon;
using VRC.Networking;
using MelonLoader;
using System.Reflection;
using UnityEngine;
using AccessTools = HarmonyLib.AccessTools;

namespace uwuclara.Network
{
    public class Patches : uwuclara
    {

        internal static void initPatches(HarmonyLib.Harmony instance)
        {

            MelonLogger.Msg("Initializing Patches...");

            instance.Patch(AccessTools.Property(typeof(Time), "smoothDeltaTime").GetMethod, null, NetworkManager.GetLocalPatch<FakeFPS>("Frame"));
            instance.Patch(AccessTools.Property(typeof(PhotonPeer), "RoundTripTime").GetMethod, null, NetworkManager.GetLocalPatch<FakePing>("Ping"));
            instance.Patch(typeof(VRC_EventHandler).GetMethod("InternalTriggerEvent"), NetworkManager.GetLocalPatch<TriggerWorld>("OnTriggerWorld"));
            instance.Patch(typeof(UdonSync).GetMethod("UdonSyncRunProgramAsRPC"), NetworkManager.GetLocalPatch<Udon>("OnUdon"));
            instance.Patch(typeof(VRC_EventDispatcherRFC).GetMethod("Method_Public_Void_Player_VrcEvent_VrcBroadcastType_Int32_Single_0"), NetworkManager.GetLocalPatch<RPC>("onRPC"));
            
            (from m in typeof(VRCPlayer).GetMethods()
                where m.Name.StartsWith("Method_Private_Void_GameObject_VRC_AvatarDescriptor_Boolean_")
                select m).ToList().ForEach(delegate (MethodInfo m)
            {
                instance.Patch(typeof(VRCPlayer).GetMethod(m.Name), NetworkManager.GetLocalPatch<AvatarLoaded>("OnAvaLoaded"));
            });

        }
        
    }
    
}