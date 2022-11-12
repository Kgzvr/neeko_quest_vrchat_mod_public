using ExitGames.Client.Photon;
using uwuclara.Wrappers;
using VRC;
using MelonLoader;

namespace uwuclara.Network
{
    public class PhotonEvents
    {

        internal static bool OnPhotonReceive(ref EventData __0)
        {


            if (RoomManager.prop_Boolean_2 && __0.Sender != 0 && __0.Code != 1 && __0.Code == 33&& __0.Code != 7)
            {
                
                Player player = Player_Wrapper.getPlayerByPhotonID(__0.Sender)._player;
                string displaySenderName = (player != null) ? player.prop_APIUser_0.displayName : string.Concat(__0.Sender);
            
                MelonLogger.Msg("User: (" + displaySenderName + ") send an Event.");
                
            }
            
            return true;

        }
        
        internal static void OnPhotonSent(){} // For now empty as I don't wanna send events that have a higher chances of getting banned
        
    }
}