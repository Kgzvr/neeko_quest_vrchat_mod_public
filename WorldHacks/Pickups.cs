using System.Linq;
using UnityEngine;
using VRC.SDKBase;
using VRC.SDK3.Components;

namespace uwuclara.WorldHacks
{
    class Pickups
    {
        
        public static bool disablePickupsEnabled { get; internal set; }
        public static bool itemsAreNotPickableEnabled { get; internal set; }
        
        internal static void respawnAllObjects()
        {
            foreach (VRC_Pickup vrc_Pickup in Object.FindObjectsOfType<VRC_Pickup>())
            {
                Networking.LocalPlayer.TakeOwnership(vrc_Pickup.gameObject);
                vrc_Pickup.transform.localPosition = new Vector3(0f, -100000f, 0f);
            }
        }

        internal static void bringPickupsToTarget(VRCPlayer vrcplayer)
        {

            foreach (VRC_Pickup vrc_Pickup in Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray())
            {
                if (vrc_Pickup.gameObject)
                {
                    Networking.LocalPlayer.TakeOwnership(vrc_Pickup.gameObject);
                    var transform1 = vrc_Pickup.transform;
                    transform1.localPosition = new Vector3(0f, 0.3f, 0f);
                    transform1.position = vrcplayer._player.transform.position + new Vector3(0f, 0.3f, 0f);
                }
            }
            foreach (VRC_Pickup vrc_Pickup2 in Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray())
            {
                if (vrc_Pickup2.gameObject)
                {
                    Networking.LocalPlayer.TakeOwnership(vrc_Pickup2.gameObject);
                    var transform2 = vrc_Pickup2.transform;
                    transform2.localPosition = new Vector3(0f, 0.3f, 0f);
                    transform2.position = vrcplayer._player.transform.position + new Vector3(0f, 0.3f, 0f);
                }
            }
            foreach (VRCPickup vrcpickup in Resources.FindObjectsOfTypeAll<VRCPickup>().ToArray())
            {
                if (vrcpickup.gameObject)
                {
                    Networking.LocalPlayer.TakeOwnership(vrcpickup.gameObject);
                    var transform3 = vrcpickup.transform;
                    transform3.localPosition = new Vector3(0f, 0.3f, 0f);
                    transform3.position = vrcplayer._player.transform.position + new Vector3(0f, 0.3f, 0f);
                }
            }

        }

        internal static void disablePickups()
        {

            foreach (VRC_Pickup vrc_Pickup in Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray())
            {

                vrc_Pickup.gameObject.SetActive(!disablePickupsEnabled);

            }

        }

        internal static void itemsAreNotPickable()
        {

            foreach (VRC_Pickup vrc_Pickup in Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray())
            {

                vrc_Pickup.GetComponent<VRC_Pickup>().pickupable = !itemsAreNotPickableEnabled;

            }

        }

        internal static void forcePickup()
        {
            
            foreach (VRC_Pickup vrc_Pickup in Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray())
            {
                
                vrc_Pickup.GetComponent<VRC_Pickup>().DisallowTheft = false;
                vrc_Pickup.GetComponent<VRC_Pickup>().pickupable = true;
                vrc_Pickup.GetComponent<VRC_Pickup>().allowManipulationWhenEquipped = true;
                vrc_Pickup.GetComponent<VRC_Pickup>().proximity = float.MaxValue;
                vrc_Pickup.GetComponent<VRC_Pickup>().orientation = VRC_Pickup.PickupOrientation.Any;

            }
            
        }

    }
}
