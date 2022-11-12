using VRC;
using VRC.SDKBase;
using MelonLoader;
using UnityEngine;

namespace uwuclara.PlayerHacks
{
    class SpeedHack
    {

        public static bool SpeedEnabled { get; internal set; }
        private static float speedCurrent = 4f;

        internal static void setSpeedToggle()
        {

            if(SpeedEnabled)
            {

                SpeedEnabled = true;
                setSpeed(speedCurrent);

            }
            else
            {

                SpeedEnabled = false;
                resetSpeed();

            }

        }

        private static void setSpeed(float speed)
        {
            Networking.LocalPlayer.SetWalkSpeed(speed);
            Networking.LocalPlayer.SetRunSpeed(speed);
            Networking.LocalPlayer.SetStrafeSpeed(speed);
            Player.prop_Player_0.gameObject.GetComponent<CharacterController>().enabled = true;

        }

        internal static void resetSpeed()
        {

            var speed = 4f;

            setSpeed(speed);

        }

        internal static void updateSpeed(float update)
        {

            if (update >= 0f)
            {
                
                speedCurrent = speedCurrent + update;

                Config.ConfManager.speedValue.Value = speedCurrent;

                MelonPreferences.Save();

                if(SpeedEnabled)
                {
                    setSpeed(speedCurrent);
                }
                
            }

        }

    }

}
