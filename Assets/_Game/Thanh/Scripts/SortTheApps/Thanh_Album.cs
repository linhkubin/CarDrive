using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ThanhDev
{
    public class Thanh_Album : MonoBehaviour
    {
        public Thanh_AlbumHolder[] holder;
        public GameObject correctImage;

        public void CheckSameApp()
        {
            for(int i=1; i<holder.Length; i++)
            {
                if (holder[i-1].AppType != holder[i].AppType)
                {
                    return;
                }
            }

            if (holder[0].AppType == AppType.Null)
            {
                return;
            }

            OnDoneApps();

            return;
        }

        private void OnDoneApps()
        {
            for (int i = 0; i < holder.Length; i++)
            {
                holder[i].DraggableItem.image.raycastTarget = false;
            }

            correctImage.SetActive(true);
        }    
    }
}


