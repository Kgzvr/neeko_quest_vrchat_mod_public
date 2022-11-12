
namespace uwuclara.Network
{
    class FakeFPS
    {

        private static int timer;
        private static float timer_current_number = Config.ConfManager.fakeFPS.Value;

        internal static void Frame(ref float __result)
        {
            try
            {
                if (Config.ConfManager.fakeFPSEnabled.Value)
                {
                    if (Config.ConfManager.ping_FPSFluctuate.Value)
                    {
                        if (timer >= 500)
                        {
                            timer_current_number = new System.Random().Next(System.Convert.ToInt32(Config.ConfManager.fakeFPS.Value) - 5, System.Convert.ToInt32(Config.ConfManager.fakeFPS.Value) + 5);
                            timer = 0;
                        }
                        else
                        {
                            timer++;
                        }
                        __result = 1f / timer_current_number;
                    }
                    else
                    {
                        __result = 1f / Config.ConfManager.fakeFPS.Value;
                    }
                }
            }
            catch
            {
            }
        }

    }
}
