using VRC.SDKBase;

namespace uwuclara.Network
{
    class TriggerWorld
    {

		internal static bool OnTriggerWorld(ref VRC_EventHandler.VrcEvent __0, ref VRC_EventHandler.VrcBroadcastType __1, ref int __2)
		{
			try
			{
				if (Config.ConfManager.blockWorldTriggers.Value)
				{
					__1 = VRC_EventHandler.VrcBroadcastType.AlwaysUnbuffered;
				}
			}
			catch
			{
			}

			return true;

		}

	}

}
