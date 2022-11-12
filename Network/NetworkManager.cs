using System.Reflection;
using Harmony;

namespace uwuclara.Network
{
    class NetworkManager
	{

        internal static HarmonyMethod GetLocalPatch<T>(string name)
        {

            return new HarmonyMethod(typeof(T).GetMethod(name, BindingFlags.Static | BindingFlags.NonPublic));

        }

    }

}
