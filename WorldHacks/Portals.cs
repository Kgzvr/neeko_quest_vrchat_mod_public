using VRC.SDKBase;

namespace uwuclara.WorldHacks
{
    class Portals
    {
        internal static int removePortals()
        {
            int num = 0;
            foreach (PortalTrigger portalTrigger in UnityEngine.Resources.FindObjectsOfTypeAll<PortalTrigger>())
            {
                if (portalTrigger.gameObject.activeInHierarchy && !(portalTrigger.gameObject.GetComponentInParent<VRC_PortalMarker>() != null))
                {
                    UnityEngine.Object.Destroy(portalTrigger.gameObject);
                    num++;
                }
            }
            return num;
        }

    }
}
