using ReMod.Core.Managers;
using uwuclara.QuickMenu;
using uwuclara.GameWorlds;

namespace uwuclara.Menus.Pages_MainMenu
{
    class GameWorldHacks : Main_Menu
    {

        private static ReCategoryPage _gameworldhacks;
        private static ReCategoryPage _murderMenuCatapage;
        private static ReCategoryPage _clubBMenuCatapage;

        internal static void GameWorldHacksMenu(UiManager _uiManager)
        {

            _gameworldhacks = _uiManager.MainMenu.AddCategoryPage("GameWorld Hacks", null, ResourceManager.Resources.gameHacksIcon);

            _gameworldhacks.AddCategory("GameWorld Hacks");
            var gameworldhacks = _gameworldhacks.GetCategory("GameWorld Hacks");

            _murderMenuCatapage = gameworldhacks.AddCategoryPage("Murder Hacks", null, ResourceManager.Resources.gameMurder4Icon);

            _murderMenuCatapage.AddCategory("Murder Hacks 1");
            var murderMenuhacks = _murderMenuCatapage.GetCategory("Murder Hacks 1");

            murderMenuhacks.AddButton("Start Game", "Start Game", () => Murder4.startGame());
            murderMenuhacks.AddButton("Abort Game", "Abort Game", () => Murder4.abortGame());
            murderMenuhacks.AddButton("Murderer Win", "Murderer Win", () => Murder4.setMurderWin());
            murderMenuhacks.AddButton("Bystander Win", "Bystander Win", () => Murder4.setBystenderWin());

            //_murderMenuCatapage.AddCategory("Murder Hacks 2");
            //var murderMenuhacks2 = _murderMenuCatapage.GetCategory("Murder Hacks 2");

            _clubBMenuCatapage = gameworldhacks.AddCategoryPage("Club B Hacks", null, ResourceManager.Resources.gameJustBClubIcon);

            _clubBMenuCatapage.AddCategory("Club B Hacks");
            var clubBMenuhacks = _clubBMenuCatapage.GetCategory("Club B Hacks");

            clubBMenuhacks.AddButton("Join room 1", "Join room 1", () => ClubB.joinRoom1());
            clubBMenuhacks.AddButton("Join room 2", "Join room 2", () => ClubB.joinRoom2());
            clubBMenuhacks.AddButton("Join room 3", "Join room 3", () => ClubB.joinRoom3());
            clubBMenuhacks.AddButton("Join room 4", "Join room 4", () => ClubB.joinRoom4());
            clubBMenuhacks.AddButton("Join room 5", "Join room 5", () => ClubB.joinRoom5());
            clubBMenuhacks.AddButton("Join room 6", "Join room 6", () => ClubB.joinRoom6());
            clubBMenuhacks.AddButton("Join room VIP", "Join room VIP", () => ClubB.joinRoomVIP());

        }

    }

}
