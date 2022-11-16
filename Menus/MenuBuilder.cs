using System.Reflection;
using MelonLoader;
using ReMod.Core.Managers;

namespace uwuclara.Menus
{
    public class MenuBuilder : uwuclara
    {
        
        internal static void MenuStart()
        {

            MelonLogger.Msg("Initializing UI...");

            _uiManager = new UiManager("Neeko#0480", ResourceManager.Resources.uwuclara);
            
            _uiManager.MainMenu.AddLabel("Neeko mod", Version, 25);
            _uiManager.MainMenu.AddSpacer();
            _uiManager.MainMenu.AddSpacer();
            _uiManager.MainMenu.AddSpacer();

            _uiManager.MainMenu.AddSpacer();
            _uiManager.MainMenu.AddSpacer();
            _uiManager.MainMenu.AddSpacer();
            _uiManager.MainMenu.AddSpacer();

            Main_Menu.InitMainMenu(_uiManager);
            Target_Menu.InitMainMenu(_uiManager);

        }
        
    }
    
}