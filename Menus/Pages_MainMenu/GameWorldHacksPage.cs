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
        private static ReCategoryPage _amongASSMenuCatapage;

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

            _murderMenuCatapage.AddCategory("Murder Hacks 2");
            var murderMenuhacks2 = _murderMenuCatapage.GetCategory("Murder Hacks 2");
            
            murderMenuhacks2.AddButton("Bring Knife", "Bring Knife", () => Murder4.bringKnife());
            murderMenuhacks2.AddButton("Bring Revolver", "Bring Revolver", () => Murder4.bringRevolver());
            murderMenuhacks2.AddButton("Bring ShotGun (Stand On Collider)", "Bring ShotGun (Stand On Collider)", () => Murder4.bringShotGun());
            murderMenuhacks2.AddButton("Bring Luger (Stand On Collider)", "Bring Luger (Stand On Collider)", () => Murder4.bringLuger());

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
            
            _amongASSMenuCatapage = gameworldhacks.AddCategoryPage("Among ASS Hacks", null, ResourceManager.Resources.gameAmongASSIcon);
            
            _amongASSMenuCatapage.AddCategory("Among ASS Hacks 1");
            var amongASSMenuhacks = _amongASSMenuCatapage.GetCategory("Among ASS Hacks 1");
            
            amongASSMenuhacks.AddButton("Start Game", "Start Game", () => AmongASS_IHateMyself.startGame());
            amongASSMenuhacks.AddButton("Abort Game", "Abort Game", () => AmongASS_IHateMyself.abortGame());
            amongASSMenuhacks.AddButton("Importer Win", "Importer Win", () => AmongASS_IHateMyself.setImpostorWin());
            amongASSMenuhacks.AddButton("Crew Win", "Crew Win", () => AmongASS_IHateMyself.setCrewMateWin());
            
            _amongASSMenuCatapage.AddCategory("Among ASS Hacks 2");
            var amongASSMenuhacks2 = _amongASSMenuCatapage.GetCategory("Among ASS Hacks 2");
            
            amongASSMenuhacks2.AddButton("Complete Tasks", "Complete Tasks", () => AmongASS_IHateMyself.completeTasks());
            amongASSMenuhacks2.AddButton("Stop Voting", "Stop Voting", () => AmongASS_IHateMyself.stopVoting());
            amongASSMenuhacks2.AddButton("Start Meeting", "Start Meeting", () => AmongASS_IHateMyself.startMeeting());
            
            _amongASSMenuCatapage.AddCategory("Among ASS Hacks 3");
            var amongASSMenuhacks3 = _amongASSMenuCatapage.GetCategory("Among ASS Hacks 3");
            
            amongASSMenuhacks3.AddButton("Repair Oxygen", "Repair Oxygen", () => AmongASS_IHateMyself.repairOxygen());
            amongASSMenuhacks3.AddButton("Break Oxygen", "Break Oxygen", () => AmongASS_IHateMyself.breakOxygen());
            amongASSMenuhacks3.AddButton("Repair Light", "Repair Light", () => AmongASS_IHateMyself.fixlights());
            amongASSMenuhacks3.AddButton("Break Lights", "Break Lights", () => AmongASS_IHateMyself.breakLights());
            amongASSMenuhacks3.AddButton("Fix Comms", "Fix Comms", () => AmongASS_IHateMyself.fixComms());
            amongASSMenuhacks3.AddButton("Break Comms", "Break Comms", () => AmongASS_IHateMyself.breakComms());
            
        }

    }

}
