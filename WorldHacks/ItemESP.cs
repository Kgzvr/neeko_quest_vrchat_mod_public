using VRC.Udon;
using UnityEngine;
using VRC.SDKBase;
using UnhollowerBaseLib;

namespace uwuclara.WorldHacks
{
    class ItemESP
    {
        
        public static bool ItemESPEnabled { get; internal set; }
        public static bool TriggerESPEnabled { get; internal set; }
        
        internal static void ToggleBetterESP()
        {
            foreach (VRC_Pickup vrc_Pickup in Resources.FindObjectsOfTypeAll<VRC_Pickup>())
            {
                if (!(vrc_Pickup == null) && !(vrc_Pickup.gameObject == null) && vrc_Pickup.gameObject.active && vrc_Pickup.enabled && vrc_Pickup.pickupable && !vrc_Pickup.name.Contains("ViewFinder") && !(HighlightsFX.prop_HighlightsFX_0 == null))
                {
                    HighlightsFX.prop_HighlightsFX_0.Method_Public_Void_Renderer_Boolean_0(vrc_Pickup.GetComponentInChildren<MeshRenderer>(), ItemESPEnabled);
                }
            }
        }

        internal static void ToggleBetterTrigger()
        {
            Il2CppArrayBase<VRC_Trigger> il2CppArrayBase = Resources.FindObjectsOfTypeAll<VRC_Trigger>();
            Il2CppArrayBase<UdonBehaviour> il2CppArrayBase2 = Resources.FindObjectsOfTypeAll<UdonBehaviour>();
            foreach (VRC_Trigger vrc_Trigger in il2CppArrayBase)
            {
                if (!(vrc_Trigger == null) && !(vrc_Trigger.gameObject == null) && vrc_Trigger.gameObject.active && !vrc_Trigger.name.Contains("ViewFinder") && !(HighlightsFX.prop_HighlightsFX_0 == null))
                {
                    HighlightsFX.prop_HighlightsFX_0.Method_Public_Void_Renderer_Boolean_0(vrc_Trigger.GetComponentInChildren<MeshRenderer>(), TriggerESPEnabled);
                }
            }
            foreach (UdonBehaviour udonBehaviour in il2CppArrayBase2)
            {
                if (!(udonBehaviour == null) && !(udonBehaviour.gameObject == null) && udonBehaviour.gameObject.active && !udonBehaviour.name.Contains("ViewFinder") && !(HighlightsFX.prop_HighlightsFX_0 == null) && udonBehaviour._eventTable.System_Collections_IDictionary_Contains("_interact"))
                {
                    HighlightsFX.prop_HighlightsFX_0.Method_Public_Void_Renderer_Boolean_0(udonBehaviour.GetComponentInChildren<MeshRenderer>(), TriggerESPEnabled);
                }
            }
        }
    }
}
