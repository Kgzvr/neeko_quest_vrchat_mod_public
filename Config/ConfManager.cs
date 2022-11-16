using MelonLoader;
using System.IO;

namespace uwuclara.Config
{
    class ConfManager
    {
        
        public static readonly string resourcePath = Path.Combine("/storage/emulated/0/Download/", "NeekoVRCMod");
        
        private const string SettingsCategory = "Neeko";
        
        internal static MelonPreferences_Entry<int> fakePing;
        internal static MelonPreferences_Entry<float> fakeFPS;
        internal static MelonPreferences_Entry<bool> fakePingEnabled;
        internal static MelonPreferences_Entry<bool> fakeFPSEnabled;
        internal static MelonPreferences_Entry<bool> ping_FPSFluctuate;
        internal static MelonPreferences_Entry<bool> udonLogger;
        internal static MelonPreferences_Entry<bool> antiUdon;
        internal static MelonPreferences_Entry<bool> blockWorldTriggers;
        internal static MelonPreferences_Entry<bool> avatarLogging;
        internal static MelonPreferences_Entry<bool> antiRPC;
        internal static MelonPreferences_Entry<bool> rpcLogger;
        internal static MelonPreferences_Entry<bool> antiTPRPC;
        internal static MelonPreferences_Entry<bool> antiInvalidRPC;
        internal static MelonPreferences_Entry<float> speedValue;
        internal static MelonPreferences_Entry<float> flySpeedValue;
        internal static MelonPreferences_Entry<int> headLightRange;
        internal static MelonPreferences_Entry<float> headLightPower;
        public static void initConfig()
        {

            MelonLogger.Msg("Initializing Config...");

            var category = MelonPreferences.CreateCategory(SettingsCategory, "Neeko");

            category.SetFilePath(resourcePath + "/config.cfg");

            fakePing = category.CreateEntry("fakePing", 30, "Fake Ping Value");
            fakeFPS = category.CreateEntry("fakeFPS", 80f, "Fake FPS Value");
            fakePingEnabled = category.CreateEntry("fakePingEnabled", false, "Fake Ping Enabled");
            fakeFPSEnabled = category.CreateEntry("fakeFPSEnabled", false, "Fake FPS Enabled");
            ping_FPSFluctuate = category.CreateEntry("ping_FPSFluctuate", false, "Fluctuate FPS/Ping");
            udonLogger = category.CreateEntry("udonLogger", false, "Log Udon Events");
            antiUdon = category.CreateEntry("antiUdon", false, "Block Udon Events");
            blockWorldTriggers = category.CreateEntry("blockWorldTriggers", false, "Block World Triggers");
            avatarLogging = category.CreateEntry("avatarLogging", false, "Log Avatar Change");
            antiRPC = category.CreateEntry("antiRPC", false, "Block every RPC");
            antiTPRPC = category.CreateEntry("antiTPRPC", false, "Block TP RPC");
            antiInvalidRPC = category.CreateEntry("antiInvalidRPC", false, "Blocks Invalid RPC");
            rpcLogger = category.CreateEntry("rpcLogger", false, "Log RPC");
            speedValue = category.CreateEntry("speedValue", 4.50f, "Speed Value");
            flySpeedValue = category.CreateEntry("flySpeedValue", 8f, "Fly Speed Value");
            headLightRange = category.CreateEntry("headLightRange", 5, "HeadLight Range");
            headLightPower = category.CreateEntry("headLightPower", 0.50f, "HeadLight Power");

            category.SaveToFile();

        }

    }

}
