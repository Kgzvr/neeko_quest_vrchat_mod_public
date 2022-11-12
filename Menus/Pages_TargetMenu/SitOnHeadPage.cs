using ReMod.Core.Managers;
using uwuclara.QuickMenu;
using QuestMod;
using UnityEngine;
using VRC.SDKBase;

namespace uwuclara.Menus.Pages_TargetMenu
{
    class SitOnHeadPage : Target_Menu
    {

        private static ReCategoryPage _sitOnHeadHacks;

        internal static void SitOnHeadPagePageMenu(UiManager _uiManager)
        {
            
            var targetMenu = _uiManager.TargetMenu;
            
            targetMenu.AddMenuPage("SitOnHead Hacks Menu", "SitOnHead Hacks Menu", ResourceManager.Resources.sitOnIcon);
            var targetPageSitOnHead = targetMenu.GetMenuPage("SitOnHead Hacks Menu");

            targetPageSitOnHead.AddButton("Sit On Head", "Sit On Head", () =>
            {
                SetOn(HumanBodyBones.Head);
            });
            
            targetPageSitOnHead.AddButton("Sit On Neck", "Sit On Neck", () =>
            {
                SetOn(HumanBodyBones.Neck);
            });
            
            targetPageSitOnHead.AddButton("Sit On LeftUpperArm", "Sit On LeftUpperArm", () =>
            {
                SetOn(HumanBodyBones.LeftUpperArm);
            });
            
            targetPageSitOnHead.AddButton("Sit On LeftShoulder", "Sit On LeftShoulder", () =>
            {
                SetOn(HumanBodyBones.LeftShoulder);
            });
            
            targetPageSitOnHead.AddButton("Sit On LeftHand", "Sit On LeftHand", () =>
            {
                SetOn(HumanBodyBones.LeftHand);
            });
            
            targetPageSitOnHead.AddButton("Sit On LeftFoot", "Sit On LeftFoot", () =>
            {
                SetOn(HumanBodyBones.LeftFoot);
            });
            
            targetPageSitOnHead.AddButton("Sit On RightUpperArm", "Sit On RightUpperArm", () =>
            {
                SetOn(HumanBodyBones.RightUpperArm);
            });
            
            targetPageSitOnHead.AddButton("Sit On RightShoulder", "Sit On RightShoulder", () =>
            {
                SetOn(HumanBodyBones.RightShoulder);
            });
            
            targetPageSitOnHead.AddButton("Sit On RightHand", "Sit On RightHand", () =>
            {
                SetOn(HumanBodyBones.RightHand);
            });
            
            targetPageSitOnHead.AddButton("Sit On RightFoot", "Sit On RightFoot", () =>
            {
                SetOn(HumanBodyBones.RightFoot);
            });

        }

        private static void SetOn(HumanBodyBones bone)
        {
            
            VRCPlayerApi player1 = IUserExtension.GetVRCPlayer().field_Private_VRCPlayerApi_0;
            if (player1 != null)
            {

                PlayerHacks.SitOn.sitOnPlayer(bone, player1, VRCPlayer.field_Internal_Static_VRCPlayer_0.field_Private_VRCPlayerApi_0);
                PlayerHacks.SitOn.SitOnEnabled = true;

            }
            
        }
        
    }
    
}