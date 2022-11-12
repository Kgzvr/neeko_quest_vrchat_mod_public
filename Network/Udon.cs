using VRC;

namespace uwuclara.Network
{
    class Udon
    {

		internal static bool OnUdon(string __0, Player __1)
		{
			if (Config.ConfManager.udonLogger.Value)
			{
				MelonLoader.MelonLogger.Msg("[Udon] Type: " + __0 + " | From " + __1.prop_APIUser_0.displayName);
			}

			return !Config.ConfManager.antiUdon.Value;

		}

	}

}
