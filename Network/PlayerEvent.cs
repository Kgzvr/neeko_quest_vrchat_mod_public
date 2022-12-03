using VRC;
using MelonLoader;

namespace uwuclara.Network
{
    class PlayerEvent
    {

        internal static void OnJoinEvent(Player player)
        {

            if (Config.ConfManager.playerLogger.Value)
            {
                OnJoinLog(player);
            }

        }

        internal static void OnLeaveEvent(Player player)
        {
            
            if (Config.ConfManager.playerLogger.Value)
            {
                OnLeaveLog(player);
            }
            
        }
        
        private static void OnJoinLog(Player player)
        {

            MelonLogger.Msg("[Join] " + player.prop_APIUser_0.displayName);

        }

        private static void OnLeaveLog(Player player)
        {
            
            MelonLogger.Msg("[Leave] " + player.prop_APIUser_0.displayName);
            
        }
        
    }
    
}