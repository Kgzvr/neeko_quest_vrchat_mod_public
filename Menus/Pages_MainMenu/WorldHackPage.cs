using ReMod.Core.Managers;
using uwuclara.QuickMenu;
using uwuclara.WorldHacks;
using MelonLoader;

namespace uwuclara.Menus.Pages_MainMenu
{
    class WorldHackPage : Main_Menu
    {

        private static ReCategoryPage _worldHacks;

        internal static void WorldHacksMenu(UiManager _uiManager)
        {

            _worldHacks = _uiManager.MainMenu.AddCategoryPage("World Hacks", null, ResourceManager.Resources.worldHacksIcon);


            _worldHacks.AddCategory("World Hacks Toggles");
            var worldhacks = _worldHacks.GetCategory("World Hacks Toggles");
            worldhacks.AddToggle("Item ESP", "Item ESP", ToggleItemESP);
            worldhacks.AddToggle("Trigger ESP", "Trigger ESP", ToggleTriggerESP);
            worldhacks.AddToggle("Disable Pickups", "Disable Pickups", DisablePickups);
            worldhacks.AddToggle("Items Not Pickable", "Items Not Pickable", ItemNotPickable);
            worldhacks.AddToggle("HeadLight", "HeadLight", HeadLightToggle);


            _worldHacks.AddCategory("World Hacks Buttons");
            var worldhacks2 = _worldHacks.GetCategory("World Hacks Buttons");
            worldhacks2.AddButton("Respawn Pickups", "Respawn Pickups", () => Pickups.respawnAllObjects());
            worldhacks2.AddButton("Force Pickups", "Force Pickups", () => Pickups.forcePickup());
            worldhacks2.AddButton("Delete Portals", "Delete Portals", () =>
            {
                int num = Portals.removePortals();
                MelonLogger.Msg("You have removed " + num + " portal/s. ");
            });
            worldhacks2.AddButton("Download WCA", "Download WCA", () =>
            {
                if (RoomManager.field_Internal_Static_ApiWorld_0.assetUrl != null)
                {
                    MelonLogger.Msg("World: " + RoomManager.field_Internal_Static_ApiWorld_0.name + " Asset url : " + RoomManager.field_Internal_Static_ApiWorld_0.assetUrl);
                }
            });


                _worldHacks.AddCategory("HeadLight Settings");
                var _worldhacks_HeadLightSettings = _worldHacks.GetCategory("HeadLight Settings");
                _worldhacks_HeadLightSettings.AddButton("Power ++(.25)", "Power ++(.25)", () =>
                {
                    if (Config.ConfManager.headLightPower.Value <= 5)
                    {
                        HeadLightLocal.updateHeadLightValue(0.25f);
                        Config.ConfManager.headLightPower.Value++;
                        MelonPreferences.Save();
                    }
                });
                
                _worldhacks_HeadLightSettings.AddButton("Power --(.25)", "Power --(.25)", () =>
                {
                    if(Config.ConfManager.headLightPower.Value >= 0)
                    {
                        HeadLightLocal.updateHeadLightValue(-0.25f);
                        Config.ConfManager.headLightPower.Value--;
                        MelonPreferences.Save();
                    }
                });

                _worldhacks_HeadLightSettings.AddButton("Range ++(1)", "Range ++(1)", () =>
                {
                    if (Config.ConfManager.headLightRange.Value <= 20)
                    {
                        HeadLightLocal.updateHeadLightValue(0, 1);
                        Config.ConfManager.headLightRange.Value++;
                        MelonPreferences.Save();
                    }
                });
                _worldhacks_HeadLightSettings.AddButton("Range --(1)", "Range --(1)", () =>
                {
                    if (Config.ConfManager.headLightRange.Value >= 0)
                    {
                        HeadLightLocal.updateHeadLightValue(0, -1);
                        Config.ConfManager.headLightRange.Value--;
                        MelonPreferences.Save();
                    }
                });

        }

    }

}
