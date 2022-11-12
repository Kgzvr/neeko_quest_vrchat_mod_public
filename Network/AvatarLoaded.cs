using VRC.SDKBase;
using UnityEngine;
using VRC;

namespace uwuclara.Network
{
    class AvatarLoaded
    {

		private static string last_log;

		internal static bool OnAvaLoaded(GameObject __0, VRC_AvatarDescriptor __1, bool __2, VRCPlayer __instance)
		{
			try
			{
				if (Config.ConfManager.avatarLogging.Value)
				{
					Player player = __instance._player;
					string text = string.Concat(new object[]
					{
						"[Avatar Log] User: (",
						player.prop_VRCPlayerApi_0.displayName,
						") switched to avatar: ",
						player.prop_ApiAvatar_0.name,
						"(",
						player.prop_ApiAvatar_0.id,
						") Author: (",
						player.prop_ApiAvatar_0.authorName,
						") Created: (",
						player.prop_ApiAvatar_0.created_at.ToString(),
						") Last Updated: (",
						player.prop_ApiAvatar_0.updated_at.ToString(),
						")"
					});

					if (last_log != text)
					{

						last_log = text;
						MelonLoader.MelonLogger.Msg(text);

					}
				}
			}
			catch
			{
			}
			return true;
		}

	}

}
