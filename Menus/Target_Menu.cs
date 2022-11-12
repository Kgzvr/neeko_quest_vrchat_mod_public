using ReMod.Core.Managers;
using MelonLoader;
using QuestMod;
using uwuclara.QuickMenu;
using uwuclara.Menus.Pages_TargetMenu;
using VRC;
using uwuclara.Wrappers;
using uwuclara.WorldHacks;

namespace uwuclara.Menus
{
    class Target_Menu
    {

        private static UiManager _uiManager;

        private static ReCategoryPage _murderCatapage;

        public static void InitMainMenu(UiManager UIManager)
        {

            _uiManager = UIManager;

            MelonLogger.Msg("Initializing Target Menu...");

            //TARGET MENU
            var targetMenu = _uiManager.TargetMenu;


            targetMenu.AddButton("Teleport", "Teleports to target.", () =>
            {
                VRCPlayer.field_Internal_Static_VRCPlayer_0.field_Private_VRCPlayerApi_0.TeleportTo(IUserExtension.GetVRCPlayer().transform.position, IUserExtension.GetVRCPlayer().transform.rotation);
            });

            //SitOnHead menu
            SitOnHeadPage.SitOnHeadPagePageMenu(_uiManager); 

            targetMenu.AddButton("Bring Objects to target", "Bring Objects to target.", () =>
            {

                Player player = IUserExtension.GetVRCPlayer()._player;
                VRCPlayer vrcplayer = (player != null) ? player._vrcplayer : null;
                if (vrcplayer != null)
                {
                    Pickups.bringPickupsToTarget(vrcplayer);
                }

            });

            targetMenu.AddButton("Force Clone", "Force Clone.", () =>
            {

                Player player = IUserExtension.GetVRCPlayer()._player;
                VRCPlayer vrcplayer = (player != null) ? player._vrcplayer : null;
                if (vrcplayer != null)
                {
                    if (vrcplayer._player.prop_ApiAvatar_0.releaseStatus != "public")
                    {

                        MelonLogger.Msg("This avatar is private.");

                    }
                    else
                    {

                        Player_Wrapper.switchToAvi(vrcplayer._player.prop_ApiAvatar_0.id);

                    }

                }

            });

            targetMenu.AddButton("Download VRCA", "Download VRCA", () =>
            {

                Player player = IUserExtension.GetVRCPlayer()._player;
                VRCPlayer vrcplayer = (player != null) ? player._vrcplayer : null;
                if (vrcplayer != null)
                {

                    string text = "None";

                    if (vrcplayer._player.prop_ApiAvatar_0.assetUrl != null)
                    {
                        text = vrcplayer._player.prop_ApiAvatar_0.assetUrl;
                    }

                    MelonLogger.Msg("Avatar (QUEST) Asset url : " + text);

                }

            });

            targetMenu.AddButton("Print UserID to log", "Print UserID to log.", () =>
            {

                VRCPlayer player3 = IUserExtension.GetVRCPlayer();
                if (player3 != null)
                {
                    MelonLogger.Msg("Selected User ID: " + player3._player.prop_APIUser_0.id);
                }

            });

            targetMenu.AddButton("Print AvatarID to log", "Print AvatarID to log.", () =>
            {

                VRCPlayer player4 = IUserExtension.GetVRCPlayer();
                if (player4 != null)
                {
                    MelonLogger.Msg("Selected Avatar ID: " + player4._player.prop_ApiAvatar_0.assetUrl);
                }

            });

            //Murder 4 game menu
            //Murder4Page.Murder4PageMenu(_uiManager);     

        }

    }
}
