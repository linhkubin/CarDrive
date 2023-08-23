using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ThanhDev
{
    public class Thanh_AlbumHolder : MonoBehaviour, IDropHandler
    {
        public void OnDrop(PointerEventData eventData)
        {
            GameObject dropped = eventData.pointerDrag;
            Thanh_DraggableItem draggableItem = dropped.GetComponent<Thanh_DraggableItem>();
            draggableItem.SetParent(this.transform);
        }
    }
}