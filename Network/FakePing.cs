
namespace uwuclara.Network
{
    class FakePing
    {

        private static int timer;
        private static int timer_current_number = Config.ConfManager.fakePing.Value;

        internal static void Ping(ref int __result)
		{
			try
			{
				if (Config.ConfManager.fakePingEnabled.Value)
				{
					if (Config.ConfManager.ping_FPSFluctuate.Value)
					{
						if (timer >= 700)
						{
							timer_current_number = new System.Random().Next(Config.ConfManager.fakePing.Value - 5, Config.ConfManager.fakePing.Value + 5);
							timer = 0;
						}
						else
						{
							timer++;
						}
						__result = timer_current_number;
					}
					else
					{
						__result = Config.ConfManager.fakePing.Value;
					}
				}
			}
			catch
			{
			}

		}

    }
}
