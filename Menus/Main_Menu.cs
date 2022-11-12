using ReMod.Core.Managers;
using MelonLoader;
using uwuclara.PlayerHacks;
using uwuclara.WorldHacks;
using uwuclara.Menus.Pages_MainMenu;

namespace uwuclara.Menus
{
    class Main_Menu
    {

        private static UiManager _uiManager;

        public static void InitMainMenu(UiManager UIManager)
        {

            _uiManager = UIManager;

            MelonLogger.Msg("Initializing Main Menu...");

            //MAIN MENU

            UserHacks.UserHacksMenu(_uiManager);

            WorldHackPage.WorldHacksMenu(_uiManager);

            NetworkHacks.NetworkHacksMenu(_uiManager);

            GameWorldHacks.GameWorldHacksMenu(_uiManager);        

        }

        //------------------------------------------------------------------------------TOGGLES--------------------------------------------------------------------------------------------------//

        internal static void ToggleSelfHide(bool value)
        {
            if (SelfHide.SelfHideEnabled)
            {
                SelfHide.SelfHideEnabled = false;
                
                SelfHide.selfhidePlayer();
            }
            else
            {
                SelfHide.SelfHideEnabled = true;
                SelfHide.selfhidePlayer();
            }
        }

        internal static void ToggleESP(bool value)
        {
            if (PlayerESP.PlayerESPEnabled)
            {
                PlayerESP.PlayerESPEnabled = false;
                PlayerESP.espmethod();
            }
            else
            {
                PlayerESP.PlayerESPEnabled = true;
                PlayerESP.espmethod();
            }
        }

        internal static void ToggleItemESP(bool value)
        {
            if (ItemESP.ItemESPEnabled)
            {
                ItemESP.ItemESPEnabled = false;
                ItemESP.ToggleBetterESP();
            }
            else
            {
                ItemESP.ItemESPEnabled = true;
                ItemESP.ToggleBetterESP();
            }
        }

        internal static void ToggleSpeed(bool value)
        {
            if (SpeedHack.SpeedEnabled)
            {
                SpeedHack.SpeedEnabled = false;
                SpeedHack.setSpeedToggle();
            }
            else
            {
                SpeedHack.SpeedEnabled = true;
                SpeedHack.setSpeedToggle();
            }
        }

        internal static void DisablePickups(bool value)
        {
            if (Pickups.disablePickupsEnabled)
            {
                Pickups.disablePickupsEnabled = false;
                Pickups.disablePickups();
            }
            else
            {
                Pickups.disablePickupsEnabled = true;
                Pickups.disablePickups();
            }
        }

        internal static void ItemNotPickable(bool value)
        {
            if (Pickups.itemsAreNotPickableEnabled)
            {
                Pickups.itemsAreNotPickableEnabled = false;
                Pickups.itemsAreNotPickable();
            }
            else
            {
                Pickups.itemsAreNotPickableEnabled = true;
                Pickups.itemsAreNotPickable();
            }
        }

        internal static void HeadLightToggle(bool value)
        {

            if (HeadLightLocal.HeadLightLocalEnabled)
            {
                HeadLightLocal.HeadLightLocalEnabled = false;
                HeadLightLocal.headLight();
            }
            else
            {
                HeadLightLocal.HeadLightLocalEnabled = true;
                HeadLightLocal.headLight();
            }

        }

        internal static void ToggleJetPack(bool value)
        {
            if (FlyHack.jetPackEnabled)
            {
                FlyHack.jetPackEnabled = false;
            }
            else
            {
                FlyHack.jetPackEnabled = true;
            }
        }

        internal static void ToggleFly(bool value)
        {
            if (FlyHack.flyEnabled)
            {
                FlyHack.flyEnabled = false;
            }
            else
            {
                FlyHack.flyEnabled = true;
            }
        }

        internal static void ToggleTriggerESP(bool value)
        {
            if (ItemESP.TriggerESPEnabled)
            {
                ItemESP.TriggerESPEnabled = false;
                ItemESP.ToggleBetterTrigger();
            }
            else
            {
                ItemESP.TriggerESPEnabled = true;
                ItemESP.ToggleBetterTrigger();
            }
        }

        internal static void FakePingToggle(bool value)
        {

            if (Config.ConfManager.fakePingEnabled.Value)
            {
                Config.ConfManager.fakePingEnabled.Value = value;
            }
            else
            {
                Config.ConfManager.fakePingEnabled.Value = value;
            }

            MelonPreferences.Save();

        }

        internal static void FakeFPSToggle(bool value)
        {

            if (Config.ConfManager.fakeFPSEnabled.Value)
            {
                Config.ConfManager.fakeFPSEnabled.Value = value;
            }
            else
            {
                Config.ConfManager.fakeFPSEnabled.Value = value;
            }

            MelonPreferences.Save();

        }

        internal static void FakePingFPSFluctuateTogge(bool value)
        {

            if (Config.ConfManager.ping_FPSFluctuate.Value)
            {
                Config.ConfManager.ping_FPSFluctuate.Value = value;
            }
            else
            {
                Config.ConfManager.ping_FPSFluctuate.Value = value;
            }

            MelonPreferences.Save();

        }

        internal static void UdonLoggerToggle(bool value)
        {

            if (Config.ConfManager.udonLogger.Value)
            {
                Config.ConfManager.udonLogger.Value = value;
            }
            else
            {
                Config.ConfManager.udonLogger.Value = value;
            }

            MelonPreferences.Save();

        }

        internal static void AvatarLoggerToggle(bool value)
        {

            if (Config.ConfManager.avatarLogging.Value)
            {
                Config.ConfManager.avatarLogging.Value = value;
            }
            else
            {
                Config.ConfManager.avatarLogging.Value = value;
            }

            MelonPreferences.Save();

        }

        internal static void RPCLoggerToggle(bool value)
        {

            if (Config.ConfManager.rpcLogger.Value)
            {
                Config.ConfManager.rpcLogger.Value = value;
            }
            else
            {
                Config.ConfManager.rpcLogger.Value = value;
            }

            MelonPreferences.Save();

        }

        internal static void AntiUdonToggle(bool value)
        {

            if (Config.ConfManager.antiUdon.Value)
            {
                Config.ConfManager.antiUdon.Value = value;
            }
            else
            {
                Config.ConfManager.antiUdon.Value = value;
            }

            MelonPreferences.Save();

        }

        internal static void AntiTPRPCToggle(bool value)
        {

            if (Config.ConfManager.antiTPRPC.Value)
            {
                Config.ConfManager.antiTPRPC.Value = value;
            }
            else
            {
                Config.ConfManager.antiTPRPC.Value = value;
            }

            MelonPreferences.Save();

        }

        internal static void AntiInvalidRPCToggle(bool value)
        {

            if (Config.ConfManager.antiInvalidRPC.Value)
            {
                Config.ConfManager.antiInvalidRPC.Value = value;
            }
            else
            {
                Config.ConfManager.antiInvalidRPC.Value = value;
            }

            MelonPreferences.Save();

        }

        internal static void AntiRPCToggle(bool value)
        {

            if (Config.ConfManager.antiRPC.Value)
            {
                Config.ConfManager.antiRPC.Value = value;
            }
            else
            {
                Config.ConfManager.antiRPC.Value = value;
            }

            MelonPreferences.Save();

        }

        internal static void BlockWorldTriggersToggle(bool value)
        {

            if (Config.ConfManager.blockWorldTriggers.Value)
            {
                Config.ConfManager.blockWorldTriggers.Value = value;
            }
            else
            {
                Config.ConfManager.blockWorldTriggers.Value = value;
            }

            MelonPreferences.Save();

        }

    }
}
