using UnityEngine;

namespace uwuclara.WorldHacks
{
    class HeadLightLocal
    {

        public static bool HeadLightLocalEnabled { get; internal set; }
        private static Light headlight;

        internal static void headLight()
        {

            if (GameObject.Find("Headlight_MOD") == null)
            {
                headLightIni();
            }
            
            headlight.color = Color.white;
            headlight.range = Config.ConfManager.headLightRange.Value;
            headlight.intensity = Config.ConfManager.headLightPower.Value;
            headlight.spotAngle = 270;

            headlight.enabled = HeadLightLocalEnabled;

        }

        private static void headLightIni()
        {
            GameObject headLightGameObject = new GameObject("Headlight_MOD");
            headLightGameObject.transform.SetParent(HighlightsFX.field_Private_Static_HighlightsFX_0.transform, false);
            headlight = headLightGameObject.AddComponent<Light>();
            headlight.type = LightType.Spot;
            headlight.enabled = false;
        }

        internal static void updateHeadLightValue(float power = 0f, int range = 0)
        {

            if (GameObject.Find("Headlight_MOD") != null)
            {
                headlight.range = Config.ConfManager.headLightRange.Value + range;
                headlight.intensity = Config.ConfManager.headLightPower.Value + power;
            }

        }

    }

}
