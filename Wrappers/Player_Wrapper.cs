using System.Linq;
using VRC.Udon;
using VRC.Networking;
using UnityEngine;
using VRC.UI;
using VRC;
using VRC.Core;
using UnhollowerBaseLib;

namespace uwuclara.Wrappers
{
    class Player_Wrapper
    {
        internal static GameObject GetLocalPlayer()
        {
            foreach (GameObject gameObject in Object_Wrapper.GetAllGameObjects())
            {
                if (gameObject.name.StartsWith("VRCPlayer[Local]"))
                {
                    return gameObject;
                }
            }
            return new GameObject();
        }

        internal static void switchToAvi(string avatarID)
        {

            PageAvatar component = GameObject.Find("Screens").transform.Find("Avatar").GetComponent<PageAvatar>();
            component.field_Public_SimpleAvatarPedestal_0.field_Internal_ApiAvatar_0 = new ApiAvatar
            {
                id = avatarID
            };
            component.ChangeToSelectedAvatar();

        }
        
        internal static VRCPlayer getPlayerByPhotonID(int photonID)
        {
            foreach (Player player in PlayerManager.prop_PlayerManager_0.field_Private_List_1_Player_0)
            {
                if (player.prop_VRCPlayerApi_0.playerId == photonID)
                {
                    return player._vrcplayer;
                }
            }
            return null;
        }

        internal static GameObject getplayernode(Player A)
        {

            PlayerManager playerManager = null;
            PlayerManager[] playerManagers = GameObject.FindObjectsOfType<PlayerManager>();
            foreach (PlayerManager v in playerManagers)
            {
                if (v.name.Contains("PlayerManager"))
                {

                    playerManager = v;
                    break;

                }
            }

            if (playerManager != null)
            {

                Il2CppArrayBase<Player> il2CppArrayBase = playerManager.field_Private_List_1_Player_0.ToArray();
                int num = 0;
                int num2 = 0;
                using (System.Collections.Generic.IEnumerator<Player> enumerator = il2CppArrayBase.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        if (enumerator.Current == A)
                        {
                            num2 = num;
                        }
                        else
                        {
                            num++;
                        }
                    }
                }
                foreach (GameObject gameObject in from G in Resources.FindObjectsOfTypeAll<GameObject>()
                                                  where G.GetComponent<UdonBehaviour>() != null && G.GetComponent<UdonSync>() != null && G.name.StartsWith("Player Node")
                                                  select G)
                {
                    if (gameObject.name.Contains("(" + num2.ToString() + ")"))
                    {
                        return gameObject;
                    }
                }
            }
            return null;
        }

    }
}
