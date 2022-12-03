using System;
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

            instance.Patch(AccessTools.Property(typeof(Time), "smoothDeltaTime").GetMethod, null, NetworkHelper.GetLocalPatch<FakeFPS>("Frame"));
            instance.Patch(AccessTools.Property(typeof(PhotonPeer), "RoundTripTime").GetMethod, null, NetworkHelper.GetLocalPatch<FakePing>("Ping"));
            instance.Patch(typeof(VRC_EventHandler).GetMethod("InternalTriggerEvent"), NetworkHelper.GetLocalPatch<TriggerWorld>("OnTriggerWorld"));
            instance.Patch(typeof(UdonSync).GetMethod("UdonSyncRunProgramAsRPC"), NetworkHelper.GetLocalPatch<Udon>("OnUdon"));
            instance.Patch(typeof(VRC_EventDispatcherRFC).GetMethod("Method_Public_Void_Player_VrcEvent_VrcBroadcastType_Int32_Single_0"), NetworkHelper.GetLocalPatch<RPC>("onRPC"));
           
            //instance.Patch(typeof().GetMethod("Method_Public_Virtual_New_Boolean_Byte_Object_RaiseEventOptions_SendOptions_0"), NetworkHelper.GetLocalPatch<OnPhoton>("OnSend"));// no idea new patch
            //instance.Patch(typeof().GetMethod("OnEvent"), NetworkHelper.GetLocalPatch<OnPhoton>("OnReceive")); // no idea new patch
            //instance.Patch(typeof(NetworkManager).GetMethod("Method_Public_Void_Player_0"), NetworkHelper.GetLocalPatch<PlayerEvent>("OnJoin")); // workaround in player wrapper
            //instance.Patch(typeof(NetworkManager).GetMethod("Method_Public_Void_Player_1"), NetworkHelper.GetLocalPatch<PlayerEvent>("OnLeave"));// workaround in player wrapper
            
            (from m in typeof(VRCPlayer).GetMethods()
                where m.Name.StartsWith("Method_Private_Void_GameObject_VRC_AvatarDescriptor_Boolean_")
                select m).ToList().ForEach(delegate (MethodInfo m)
            {
                instance.Patch(typeof(VRCPlayer).GetMethod(m.Name), NetworkHelper.GetLocalPatch<AvatarLoaded>("OnAvaLoaded"));
            });

        }
        
    }
    
}