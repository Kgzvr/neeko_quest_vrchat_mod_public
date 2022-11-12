using System;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;
using UnityEngine;
using VRC;
using uwuclara.Wrappers;

namespace uwuclara.GameWorlds
{
    class Murder4
    {
        internal static void startGame()
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.murder4ID))
            {

                foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (gameObject.name.Contains("Game Logic"))
                    {
                        gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(NetworkEventTarget.All, "SyncStart");
                    }
                }

            }
            else
            {

                MelonLoader.MelonLogger.Msg("You are not in the correct world.");

            }

        }

        internal static void abortGame()
        {


            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.murder4ID))
            {

                foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (gameObject.name.Contains("Game Logic"))
                    {
                        gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(NetworkEventTarget.All, "SyncAbort");
                    }
                }

            }
            else
            {

                MelonLoader.MelonLogger.Msg("You are not in the correct world.");

            }

        }

        internal static void setMurderWin()
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.murder4ID))
            {

                foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (gameObject.name.Contains("Game Logic"))
                    {
                        gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(NetworkEventTarget.All, "SyncVictoryM");
                    }
                }

            }
            else
            {

                MelonLoader.MelonLogger.Msg("You are not in the correct world.");

            }

        }

        internal static void setBystenderWin()
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.murder4ID))
            {

                foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (gameObject.name.Contains("Game Logic"))
                    {
                        gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(NetworkEventTarget.All, "SyncVictoryB");
                    }
                }

            }
            else
            {

                MelonLoader.MelonLogger.Msg("You are not in the correct world.");

            }

        }

        internal static void killPlayer(Player player)
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.murder4ID))
            {

                GameObject gameObject = Player_Wrapper.getplayernode(player);
                if (gameObject == null || gameObject.GetComponent<UdonBehaviour>() == null)
                {
                    throw new NullReferenceException();
                }
                gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(NetworkEventTarget.All, "SyncKill");

            }
            else
            {

                MelonLoader.MelonLogger.Msg("You are not in the correct world.");

            }

        }

        internal static void setMurder(Player player)
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.murder4ID))
            {

                GameObject gameObject = Player_Wrapper.getplayernode(player);
                if (gameObject == null || gameObject.GetComponent<UdonBehaviour>() == null)
                {
                    throw new NullReferenceException();
                }
                gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(NetworkEventTarget.All, "SyncAssignM");

            }
            else
            {

                MelonLoader.MelonLogger.Msg("You are not in the correct world.");

            }

        }

        internal static void setBystander(Player player)
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.murder4ID))
            {

                GameObject gameObject = Player_Wrapper.getplayernode(player);
                if (gameObject == null || gameObject.GetComponent<UdonBehaviour>() == null)
                {
                    throw new NullReferenceException();
                }
                gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(NetworkEventTarget.All, "SyncAssignB");

            }
            else
            {

                MelonLoader.MelonLogger.Msg("You are not in the correct world.");

            }

        }

        internal static void setDetective(Player player)
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.murder4ID))
            {

                GameObject gameObject = Player_Wrapper.getplayernode(player);
                if (gameObject == null || gameObject.GetComponent<UdonBehaviour>() == null)
                {
                    throw new NullReferenceException();
                }
                gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(NetworkEventTarget.All, "SyncAssignD");

            }
            else
            {

                MelonLoader.MelonLogger.Msg("You are not in the correct world.");

            }

        }
        
    }
    
}
