using ReMod.Core.Managers;
using uwuclara.QuickMenu;
using VRC.SDKBase;

namespace uwuclara.Menus.Pages_MainMenu
{
    class UserHacks : Main_Menu
    {

        private static ReCategoryPage _playerHacks;

        internal static void UserHacksMenu(UiManager _uiManager)
        {

            _playerHacks = _uiManager.MainMenu.AddCategoryPage("Player Hacks", null, ResourceManager.Resources.userHacksIcon);


            _playerHacks.AddCategory("Player Hacks Toggles");
            var playerhacks = _playerHacks.GetCategory("Player Hacks Toggles");
            playerhacks.AddToggle("JetPack", "JetPack", ToggleJetPack);
            playerhacks.AddToggle("ESP", "Turns on ESP", ToggleESP);
            playerhacks.AddToggle("Self Hide", "Self Hide", ToggleSelfHide);
            //playerhacks.AddToggle("Immobilize", "Immobilize", ImmobilizeToggle);
            playerhacks.AddToggle("Fly", "Fly", ToggleFly);
            playerhacks.AddToggle("Speed", "Speed", ToggleSpeed);


            _playerHacks.AddCategory("Player Hacks Buttons");
            var playerhacks2 = _playerHacks.GetCategory("Player Hacks Buttons");
            playerhacks2.AddButton("Force Jump", "Force jump", () => Networking.LocalPlayer.SetJumpImpulse(3));


            _playerHacks.AddCategory("Fly Control");
            var playerhacks3 = _playerHacks.GetCategory("Fly Control");
            playerhacks3.AddButton("Speed ++(1)", "Speed ++(1)", () => PlayerHacks.FlyHack.updateFlySpeed(1f));
            playerhacks3.AddButton("Speed --(1)", "Speed --(1)", () => PlayerHacks.FlyHack.updateFlySpeed(-1f));
            playerhacks3.AddButton("Reset", "Reset", () => PlayerHacks.FlyHack.resetFlySpeed());


            _playerHacks.AddCategory("Walking Speed Control");
            var playerhacks4 = _playerHacks.GetCategory("Walking Speed Control");
            playerhacks4.AddButton("Speed ++(.5)", "Speed ++(.5)", () => PlayerHacks.SpeedHack.updateSpeed(0.5f));
            playerhacks4.AddButton("Speed --(.5)", "Speed --(.5)", () => PlayerHacks.SpeedHack.updateSpeed(-0.5f));
            playerhacks4.AddButton("Reset", "Reset", () => PlayerHacks.SpeedHack.resetSpeed());


        }

    }

}
