using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ThanhDev
{
    public class Thanh_DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        public AppType appType;
        public Thanh_AlbumHolder albumHolder;

        [HideInInspector] public Transform parentAfterDrag;

        public Image image;
        
        
        public void OnBeginDrag(PointerEventData eventData)
        {
            parentAfterDrag = transform.parent;
            transform.SetParent(transform.root);
            transform.SetAsLastSibling();
            image.raycastTarget = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            transform.SetParent(parentAfterDrag);
            image.raycastTarget = true;
        }

        public void SetParent(Transform newParent,Thanh_AlbumHolder _albumHolder)
        {
            if(albumHolder != null)
            {
                albumHolder.SetAlbumOnOutDrop();
            }
            parentAfterDrag = newParent;
            albumHolder = _albumHolder;
        }

        public void SetApp(App app)
        {
            this.image.sprite = app.sprite;
            this.appType = app.appType;
        }
    }
     public enum AppType
    {
        Cat,
        Person,
        Food,
        Null,
    }
}