using VRC.Udon;
using VRC.Udon.Common.Interfaces;
using UnityEngine;

namespace uwuclara.GameWorlds
{
    
    public class AmongASS_IHateMyself
    {
	    
		internal static void startGame()
		{
			if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.amongUSID))
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (gameObject.name.Contains("Game Logic"))
					{
						gameObject.GetComponent<UdonBehaviour>()
							.SendCustomNetworkEvent(NetworkEventTarget.All, "SyncStartGame");
					}
				}
			}
		}
		
		internal static void abortGame()
		{
			if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.amongUSID))
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (gameObject.name.Contains("Game Logic"))
					{
						gameObject.GetComponent<UdonBehaviour>()
							.SendCustomNetworkEvent(NetworkEventTarget.All, "SyncAbort");
					}
				}
			}
		}
		
		internal static void setImpostorWin()
		{
			if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.amongUSID))
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (gameObject.name.Contains("Game Logic"))
					{
						gameObject.GetComponent<UdonBehaviour>()
							.SendCustomNetworkEvent(NetworkEventTarget.All, "SyncVictoryI");
					}
				}
			}
		}
		
		internal static void setCrewMateWin()
		{
			if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.amongUSID))
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (gameObject.name.Contains("Game Logic"))
					{
						gameObject.GetComponent<UdonBehaviour>()
							.SendCustomNetworkEvent(NetworkEventTarget.All, "SyncVictoryC");
					}
				}
			}
		}

		internal static void breakOxygen()
		{
			if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.amongUSID))
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (gameObject.name.Contains("Game Logic"))
					{
						gameObject.GetComponent<UdonBehaviour>()
							.SendCustomNetworkEvent(NetworkEventTarget.All, "SyncDoSabotageOxygen");
					}
				}
			}
		}
		
		internal static void repairOxygen()
		{
			if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.amongUSID))
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (gameObject.name.Contains("Game Logic"))
					{
						gameObject.GetComponent<UdonBehaviour>()
							.SendCustomNetworkEvent(NetworkEventTarget.All, "SyncRepairOxygen");
					}
				}
			}
		}

		internal static void breakLights()
		{
			if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.amongUSID))
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (gameObject.name.Contains("Game Logic"))
					{
						gameObject.GetComponent<UdonBehaviour>()
							.SendCustomNetworkEvent(NetworkEventTarget.All, "SyncDoSabotageLights");
					}
				}
			}
		}
		
		internal static void fixlights()
		{
			if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.amongUSID))
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (gameObject.name.Contains("Game Logic"))
					{
						gameObject.GetComponent<UdonBehaviour>()
							.SendCustomNetworkEvent(NetworkEventTarget.All, "SyncRepairLights");
					}
				}
			}
		}
		
		internal static void breakComms()
		{
			if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.amongUSID))
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (gameObject.name.Contains("Game Logic"))
					{
						gameObject.GetComponent<UdonBehaviour>()
							.SendCustomNetworkEvent(NetworkEventTarget.All, "SyncDoSabotageComms");
					}
				}
			}
		}
		
		internal static void fixComms()
		{
			if (RoomManager.field_Internal_Static_ApiWorld_0.id.Contains(Game_WorldIDs.amongUSID))
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (gameObject.name.Contains("Game Logic"))
					{
						gameObject.GetComponent<UdonBehaviour>()
							.SendCustomNetworkEvent(NetworkEventTarget.All, "SyncRepairComms");
					}
				}
			}
		}

    }
    
}