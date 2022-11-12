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

            if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.Touch) && SitOn.SitOnEnabled)
            {
                SitOn.SitOnEnabled = false;
                Networking.LocalPlayer.UseLegacyLocomotion();
                Physics.gravity = new Vector3(0f, -9.81f, 0f);
            }

            if (SitOn.SitOnEnabled)
            {
                if (SitOn.Caller == null || SitOn.Target == null)
                {
                    SitOn.Caller = null;
                    SitOn.Target = null;
                    SitOn.SitOnEnabled = false;
                }
                else
                {

                    Networking.LocalPlayer.UseLegacyLocomotion();
                    Physics.gravity = new Vector3(0f, 0f, 0f);

                    try
                    {

                        SitOn.Caller.gameObject.transform.position = SitOn.Target.GetBonePosition(SitOn.Bone) + new Vector3(0f, 0.15f, 0f);
                    }
                    catch
                    {
                        SitOn.SitOnEnabled = false;
                        Physics.gravity = new Vector3(0f, -9.81f, 0f);
                    }

                }

            }

        }

    }
}
