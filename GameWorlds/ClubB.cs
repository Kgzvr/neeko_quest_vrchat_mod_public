using UnityEngine;
using uwuclara.Wrappers;

namespace uwuclara.GameWorlds
{
    class ClubB
    {

        internal static void joinRoom1()
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.clubBID))
            {
                foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (gameObject.name.Contains("Bedroom 1"))
                    {
                        gameObject.SetActive(true);
                    }
                }
                Vector3 position = new Vector3(-223.7f, -11.3f, 151.1f);
                Player_Wrapper.GetLocalPlayer().transform.position = position;
            }

        }

        internal static void joinRoom2()
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.clubBID))
            {
                foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (gameObject.name.Contains("Bedroom 2"))
                    {
                        gameObject.SetActive(true);
                    }
                }
                Vector3 position = new Vector3(-211.2f, 55.7f, -91.3f);
                Player_Wrapper.GetLocalPlayer().transform.position = position;
            }

        }

        internal static void joinRoom3()
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.clubBID))
            {
                foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (gameObject.name.Contains("Bedroom 3"))
                    {
                        gameObject.SetActive(true);
                    }
                }
                Vector3 position = new Vector3(-124.6f, -11.3f, 150.3f);
                Player_Wrapper.GetLocalPlayer().transform.position = position;
            }

        }

        internal static void joinRoom4()
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.clubBID))
            {
                foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (gameObject.name.Contains("Bedroom 4"))
                    {
                        gameObject.SetActive(true);
                    }
                }
                Vector3 position = new Vector3(-111.3f, 55.7f, -90.5f);
                Player_Wrapper.GetLocalPlayer().transform.position = position;
            }

        }

        internal static void joinRoom5()
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.clubBID))
            {
                foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (gameObject.name.Contains("Bedroom 5"))
                    {
                        gameObject.SetActive(true);
                    }
                }
                Vector3 position = new Vector3(-24.7f, -11.3f, 150.6f);
                Player_Wrapper.GetLocalPlayer().transform.position = position;
            }

        }

        internal static void joinRoom6()
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.clubBID))
            {
                foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (gameObject.name.Contains("Bedroom 6"))
                    {
                        gameObject.SetActive(true);
                    }
                }
                Vector3 position = new Vector3(-11.3f, 55.7f, -90.5f);
                Player_Wrapper.GetLocalPlayer().transform.position = position;
            }


        }

        internal static void joinRoomVIP()
        {

            if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.clubBID))
            {
                foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (gameObject.name.Contains("Bedroom VIP"))
                    {
                        gameObject.SetActive(true);
                    }
                }
                Vector3 position = new Vector3(57.9796f, 62.8633f, 0.001f);
                Player_Wrapper.GetLocalPlayer().transform.position = position;
            }

        }

    }
}
