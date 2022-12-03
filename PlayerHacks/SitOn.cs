using UnityEngine;
using VRC.SDKBase;

namespace uwuclara.PlayerHacks
{
    class SitOn
    {

        public static bool SitOnEnabled { get; internal set; }
        private static VRCPlayerApi Caller;
        private static VRCPlayerApi Target;
        private static HumanBodyBones Bone;

        internal static void sitOnPlayer(HumanBodyBones bonePosition,VRCPlayerApi sitTarget, VRCPlayerApi sitCaller)
        {

            Target = sitTarget;
            Caller = sitCaller;
            Bone = bonePosition;

            SitOnEnabled = true;

        }

        internal static void sitOnPlayerUpdate()
        {

            if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.Touch) && SitOnEnabled)
            {
                SitOnEnabled = false;
                Networking.LocalPlayer.UseLegacyLocomotion();
                Physics.gravity = new Vector3(0f, -9.81f, 0f);
            }

            if (SitOnEnabled)
            {
                if (Caller == null || Target == null)
                {
                    Caller = null;
                    Target = null;
                    SitOnEnabled = false;
                }
                else
                {

                    Networking.LocalPlayer.UseLegacyLocomotion();
                    Physics.gravity = new Vector3(0f, 0f, 0f);

                    try
                    {

                        Caller.gameObject.transform.position = Target.GetBonePosition(Bone) + new Vector3(0f, 0.15f, 0f);
                    }
                    catch
                    {
                        SitOnEnabled = false;
                        Physics.gravity = new Vector3(0f, -9.81f, 0f);
                    }

                }

            }

        }

    }
}
