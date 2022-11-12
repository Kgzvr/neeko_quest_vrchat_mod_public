using System.Linq;
using VRC.SDKBase;
using VRC;
using UnhollowerBaseLib;

namespace uwuclara.Network
{
    class RPC
    {

		internal static bool onRPC(ref Player __0, ref VRC_EventHandler.VrcEvent __1, ref VRC_EventHandler.VrcBroadcastType __2, ref int __3, ref float __4)
		{
			bool parameterBool = __1.ParameterBool;

			try
			{

				if (Config.ConfManager.rpcLogger.Value)
				{

					string text = "[RPC] ";

					if (__0 != null)
					{
						text = text + __0.prop_APIUser_0.displayName + " sent ";
					}
					else
					{
						text += " invisible sent ";
					}

					text = text + __2 + " ";

					if (__1.Name != "" || __1.Name != null)
					{
						text = text + __1.Name + " ";
					}

					text = text + __1.EventType + " ";

					if (__1.ParameterObject != null)
					{
						text = text + __1.ParameterObject.name + " ";
					}

					if (parameterBool.ToString() != "False")
					{
						text = text + parameterBool.ToString() + " ";
					}

					if (__1.ParameterFloat != 0f)
					{
						text = text + __1.ParameterFloat + " ";
					}

					if (__1.ParameterInt != 0)
					{
						text = text + __1.ParameterInt + " ";
					}

					if (__1.ParameterString != "")
					{
						text = text + __1.ParameterString + " ";
					}

					if (__1.ParameterObjects != null)
					{
						for (int i = 0; i < __1.ParameterObjects.Length; i++)
						{
							text = text + __1.ParameterObjects[i].name + " ";
						}
					}

					try
					{
						Il2CppReferenceArray<Il2CppSystem.Object> il2CppReferenceArray = Networking.DecodeParameters(__1.ParameterBytes);
						for (int j = 0; j < il2CppReferenceArray.Length; j++)
						{
							text = text + Il2CppSystem.Convert.ToString(il2CppReferenceArray[j]) + " ";
						}
					}
					catch
					{
						for (int k = 0; k < __1.ParameterBytes.Length; k++)
						{
							text = text + __1.ParameterBytes[k] + " ";
						}
					}

					if (!__1.ParameterObject.name.Contains("USpeak") && __1.ParameterString != "UdonSyncRunProgramAsRPC")
					{
						MelonLoader.MelonLogger.Msg(text);
					}

				}

				if (Config.ConfManager.antiInvalidRPC.Value)
				{
					if (__0 == null)
					{
						if (Config.ConfManager.rpcLogger.Value)
						{
							MelonLoader.MelonLogger.Msg("Blocked RPC from invisible player!");
						}
						return false;
					}

					if (__1.Name.Length <= 50 && __1.ParameterString.Length <= 50)
					{
						if (!__1.Name.Any((char c) => c > 'ÿ'))
						{
							if (!__1.ParameterString.Any((char c) => c > 'ÿ') && __1.EventType == VRC_EventHandler.VrcEventType.SendRPC)
							{
								Il2CppReferenceArray<Il2CppSystem.Object> il2CppReferenceArray2 = Networking.DecodeParameters(__1.ParameterBytes);

								if (il2CppReferenceArray2.Length < 0)
								{
									if (Config.ConfManager.rpcLogger.Value)
									{
										MelonLoader.MelonLogger.Msg(__0.prop_APIUser_0.displayName + " sent invalid " + __1.EventType);
									}
									return false;
								}

								if (__1.ParameterString == "SpawnEmojiRPC" || __1.ParameterString == "PlayEmoteRPC")
								{
									if (il2CppReferenceArray2.Length > 1)
									{
										if (Config.ConfManager.rpcLogger.Value)
										{
											MelonLoader.MelonLogger.Msg(__0.prop_APIUser_0.displayName + " sent invalid SpawnEmojiRPC " + __1.EventType);
										}
										return false;
									}

									if (il2CppReferenceArray2[0].Unbox<int>() < 0 || il2CppReferenceArray2[0].Unbox<int>() > 56)
									{
										if (Config.ConfManager.rpcLogger.Value)
										{
											MelonLoader.MelonLogger.Msg(__0.prop_APIUser_0.displayName + " sent invalid SpawnEmojiRPC " + __1.EventType);
										}
										return false;
									}

								}
								else if (__1.ParameterObject.name.Contains("USpeak"))
								{
									for (int l = 0; l < il2CppReferenceArray2.Length; l++)
									{
										if (il2CppReferenceArray2[l].Unbox<int>() > 1000)
										{
											return false;
										}
									}
								}
							}
						}
					}
				}

				if (__1.EventType == VRC_EventHandler.VrcEventType.TeleportPlayer)
				{
					return !Config.ConfManager.antiTPRPC.Value;
				}

				if (Config.ConfManager.antiRPC.Value)
				{
					return false;
				}

			}
			catch
			{
			}

			return true;

		}

	}

}
