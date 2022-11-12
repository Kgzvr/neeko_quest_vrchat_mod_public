using UnityEngine;
using VRC;
using uwuclara.Wrappers;

namespace uwuclara.PlayerHacks
{
    class SelfHide
    {
        
        public static bool SelfHideEnabled { get; internal set; }
        private static string backupid;

        internal static void selfhidePlayer()
        {

            if (Player_Wrapper.GetLocalPlayer() != null)
            {

                if (SelfHideEnabled)
                {
                    if (VRCPlayer.field_Internal_Static_VRCPlayer_0._player.prop_ApiAvatar_0.id != null)
                    {
                        backupid = VRCPlayer.field_Internal_Static_VRCPlayer_0._player.prop_ApiAvatar_0.id;
                    }
                }
                else
                {

                    if (backupid != null)
                    {

                        Player_Wrapper.switchToAvi(backupid);

                    }
                }

                Player_Wrapper.GetLocalPlayer().transform.Find("ForwardDirection").gameObject.active = !SelfHideEnabled;
                AssetBundleDownloadManager.field_Private_Static_AssetBundleDownloadManager_0.gameObject.gameObject.SetActive(!SelfHideEnabled);

                GetAvatarPreviewBase().SetActive(SelfHideEnabled);

            }

        }

        private static GameObject GetAvatarPreviewBase()
        {

            GameObject UserInterface = null;

            foreach (var GameObjects in Resources.FindObjectsOfTypeAll<GameObject>())
            {
                if (GameObjects.name.Contains("UserInterface"))
                {
                    UserInterface = GameObjects;
                }
            }

            if (UserInterface != null)
            {

                return GameObject.Find(UserInterface.name + "/MenuContent/Screens/Avatar/AvatarPreviewBase");

            }
            else
            {

                return null;

            }

        }

    }
}
