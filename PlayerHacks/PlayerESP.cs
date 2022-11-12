using UnityEngine;
using VRC;

namespace uwuclara.PlayerHacks
{
    class PlayerESP
    {

        public static bool PlayerESPEnabled { get; internal set; }

        internal static void esprefresh(Player player)
        {
            if (PlayerESPEnabled && player != null)
            {
                if (player.gameObject.transform.Find("SelectRegion"))
                {
                    var Renderer = player.gameObject.transform.Find("SelectRegion").GetComponent<Renderer>();
                    HighlightsFX.field_Private_Static_HighlightsFX_0.field_Protected_Material_0.color = Color.red;
                    HighlightsFX.field_Private_Static_HighlightsFX_0.Method_Public_Void_Renderer_Boolean_0(Renderer, true);
                }
            }
        }

        internal static void espmethod()
        {
            foreach (Player gameObject in PlayerManager.prop_PlayerManager_0.field_Private_List_1_Player_0.ToArray())
            {
                if (gameObject.transform.Find("SelectRegion"))
                {
                    var Renderer = gameObject.transform.Find("SelectRegion").GetComponent<Renderer>();
                    HighlightsFX.field_Private_Static_HighlightsFX_0.field_Protected_Material_0.color = Color.red;
                    HighlightsFX.field_Private_Static_HighlightsFX_0.Method_Public_Void_Renderer_Boolean_0(Renderer, PlayerESPEnabled);
                }
            }
        }

    }

}

