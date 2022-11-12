using UnityEngine;
using UnityEngine.SceneManagement;

namespace uwuclara.Wrappers
{
    class Object_Wrapper
    {

        internal static GameObject[] GetAllGameObjects()
        {
            return SceneManager.GetActiveScene().GetRootGameObjects();
        }

    }

}
