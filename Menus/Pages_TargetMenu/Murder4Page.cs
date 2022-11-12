using ReMod.Core.Managers;
using uwuclara.QuickMenu;
using uwuclara.GameWorlds;
using VRC;
using QuestMod;

namespace uwuclara.Menus.Pages_TargetMenu
{
    class Murder4Page : Target_Menu
    {

        private static ReCategoryPage _murder4Hacks;

        internal static void Murder4PageMenu(UiManager _uiManager)
        {
            
            var targetMenu = _uiManager.TargetMenu;
            
            targetMenu.AddMenuPage("Murder Hacks Menu", "Murder Hacks Menu", ResourceManager.Resources.gameMurder4Icon);
            var targetPageMurder = targetMenu.GetMenuPage("Murder Hacks Menu");

            targetPageMurder.AddButton("Kill Player", "Kill Player", () =>
            {

                Player player11 = IUserExtension.GetVRCPlayer()._player;
                if (player11 != null)
                {

                    Murder4.killPlayer(player11);

                }

            });

            targetPageMurder.AddButton("Set Murderer", "Set Murderer", () =>
            {

                Player player12 = IUserExtension.GetVRCPlayer()._player;
                if (player12 != null)
                {

                    Murder4.setMurder(player12);

                }

            });
            
            targetPageMurder.AddButton("Set Bystander", "Set Bystander", () =>
            {

                Player player13 = IUserExtension.GetVRCPlayer()._player;
                if (player13 != null)
                {

                    Murder4.setBystander(player13);

                }

            });
            
            targetPageMurder.AddButton("Set Detective", "Set Detective", () =>
            {

                Player player14 = IUserExtension.GetVRCPlayer()._player;
                if (player14 != null)
                {

                    Murder4.setDetective(player14);

                }

            });
            
        }
        
    }
    
}