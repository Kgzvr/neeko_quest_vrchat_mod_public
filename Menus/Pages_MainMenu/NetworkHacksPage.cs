using ReMod.Core.Managers;
using uwuclara.QuickMenu;
using MelonLoader;

namespace uwuclara.Menus.Pages_MainMenu
{
    class NetworkHacks : Main_Menu
    {

        private static ReCategoryPage _networkhacks;

        internal static void NetworkHacksMenu(UiManager _uiManager)
        {

            _networkhacks = _uiManager.MainMenu.AddCategoryPage("Network Hacks", null, ResourceManager.Resources.networkHacksIcon);


            _networkhacks.AddCategory("Fake FPS/Ping Settings");
            var _networkhacks_FakeFPSPing = _networkhacks.GetCategory("Fake FPS/Ping Settings");

            _networkhacks_FakeFPSPing.AddToggle("Fake Ping", "Fake Ping", FakePingToggle, Config.ConfManager.fakePingEnabled.Value);
            _networkhacks_FakeFPSPing.AddToggle("Fake FPS", "Fake FPS", FakeFPSToggle, Config.ConfManager.fakeFPSEnabled.Value);
            _networkhacks_FakeFPSPing.AddToggle("Fake Fluctuate", "Fake Fluctuate", FakePingFPSFluctuateTogge, Config.ConfManager.ping_FPSFluctuate.Value);

            _networkhacks_FakeFPSPing.AddSpacer();

            _networkhacks_FakeFPSPing.AddButton("FPS ++", "FPS ++", () =>
            {
                Config.ConfManager.fakeFPS.Value++;
                MelonPreferences.Save();
            });
            _networkhacks_FakeFPSPing.AddButton("FPS --", "FPS --", () =>
            {
                Config.ConfManager.fakeFPS.Value--;
                MelonPreferences.Save();
            });

            _networkhacks_FakeFPSPing.AddButton("Ping ++", "Ping ++", () =>
            {
                Config.ConfManager.fakePing.Value++;
                MelonPreferences.Save();
            });
            _networkhacks_FakeFPSPing.AddButton("Ping --", "Ping --", () =>
            {
                Config.ConfManager.fakePing.Value--;
                MelonPreferences.Save();
            });


            _networkhacks.AddCategory("Anti Settings");
            var _networkhacks_anti = _networkhacks.GetCategory("Anti Settings");

            _networkhacks_anti.AddToggle("Anti Udon", "Anti Udon", AntiUdonToggle, Config.ConfManager.antiUdon.Value);
            _networkhacks_anti.AddToggle("Anti RPC", "Anti RPC", AntiRPCToggle, Config.ConfManager.antiRPC.Value);
            _networkhacks_anti.AddToggle("Anti Invalid RPC", "Anti Invalid RPC", AntiInvalidRPCToggle, Config.ConfManager.antiInvalidRPC.Value);
            _networkhacks_anti.AddToggle("Anti TP-RPC SDK2", "Anti TP-RPC SDK2", AntiTPRPCToggle, Config.ConfManager.antiTPRPC.Value);
            _networkhacks_anti.AddToggle("Block World Triggers SDK2", "Block World Triggers SDK2", BlockWorldTriggersToggle, Config.ConfManager.blockWorldTriggers.Value);


            _networkhacks.AddCategory("Logger Settings");
            var _networkhacks_logger = _networkhacks.GetCategory("Logger Settings");

            _networkhacks_logger.AddToggle("Udon Logger", "Udon Logger", UdonLoggerToggle, Config.ConfManager.udonLogger.Value);
            _networkhacks_logger.AddToggle("RPC Logger", "RPC Logger", RPCLoggerToggle, Config.ConfManager.rpcLogger.Value);
            _networkhacks_logger.AddToggle("Avatar Logger", "Avatar Logger", AvatarLoggerToggle, Config.ConfManager.avatarLogging.Value);
            _networkhacks_logger.AddToggle("Player Join/Leave Logger", "Player Join/Leave Logger", PlayerLoggerToggle, Config.ConfManager.playerLogger.Value);

        }

    }

}
