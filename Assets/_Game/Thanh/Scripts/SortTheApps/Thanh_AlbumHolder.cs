using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ThanhDev
{
    public class Thanh_AlbumHolder : MonoBehaviour, IDropHandler
    {
        public AppType AppType;
        public Thanh_Album Album;
        public Thanh_DraggableItem DraggableItem;
        public Image AlbumImage;

        public void OnDrop(PointerEventData eventData)
        {
            if (this.AppType != AppType.Null)
                return;
            GameObject dropped = eventData.pointerDrag;
            Thanh_DraggableItem draggableItem = dropped.GetComponent<Thanh_DraggableItem>();

            draggableItem.SetParent(this.transform,this);
            
            SetAlbumOnDrop(draggableItem);

            StartCoroutine(WaitForLockAlbum());
        }

        IEnumerator WaitForLockAlbum()
        {
            yield return new WaitForSeconds(0.2f);
            Album.CheckSameApp();
        }

        public void SetAlbumOnDrop(Thanh_DraggableItem _draggableItem)
        {
            this.AppType = _draggableItem.appType;
            AlbumImage.raycastTarget = false;
            DraggableItem = _draggableItem;
        }

        public void SetAlbumOnOutDrop()
        {
            this.AppType = AppType.Null;
            AlbumImage.raycastTarget = true;
            DraggableItem = null;
        }
    }
}