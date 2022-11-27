using MelonLoader;
using ReMod.Core.Managers;
using System.Collections;
using uwuclara.WorldHacks;
using uwuclara.Menus;
using UnhollowerRuntimeLib;
using UnityEngine;
using uwuclara.Network;

namespace uwuclara
{
    public class uwuclara : MelonMod
    {

        public const string Version = "1.0.0.5";
        internal static UiManager _uiManager;
        internal static GameObject UserInterface;
        
        public override void OnApplicationStart()
        {

            MelonLogger.Msg("Neeko quest mod by Neeko#0480. v" + Version);

            ResourceManager.Resources.InitResources();
            Config.ConfManager.initConfig();
            Patches.initPatches(HarmonyInstance);
            
            startWaitForUI();
            
        }

        public void OnMenuStart()
        {
            
            MenuBuilder.MenuStart();
            
        }

        public override void OnUpdate()
        {

            if (PlayerHacks.PlayerESP.PlayerESPEnabled)
            {
                new WaitForSeconds(10f);
                PlayerHacks.PlayerESP.espmethod();
            }

            PlayerHacks.FlyHack.fly();

            PlayerHacks.FlyHack.jetPack();

            PlayerHacks.SitOn.sitOnPlayerUpdate();

        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {

            if (buildIndex == -1)
            {

                if(Pickups.itemsAreNotPickableEnabled)
                {
                    Pickups.itemsAreNotPickable();
                }

                if (Pickups.disablePickupsEnabled)
                {
                    Pickups.disablePickups();
                }

            }

        }
        
        private void startWaitForUI()
        {
            
            ClassInjector.RHelperRegisterTypeInIl2Cpp<EnableDisableListener>();
            MelonCoroutines.Start(WaitForUI());
            IEnumerator WaitForUI()
            {
                while (ReferenceEquals(VRCUiManager.field_Private_Static_VRCUiManager_0, null)) yield return null; // wait till  isnt null
                foreach (var GameObjects in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (GameObjects.name.Contains("UserInterface"))
                    {
                        UserInterface = GameObjects;
                    }
                }
                while (ReferenceEquals(QuickMenuEx.Instance, null)) yield return null;

                OnMenuStart();

            }
            
        }

    }

}
