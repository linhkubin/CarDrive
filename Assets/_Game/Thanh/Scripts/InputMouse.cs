using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThanhDev
{
    public class InputMouse : MonoBehaviour
    {
        private void OnMouseDrag()
        {
            Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(transform.position).z);
            Vector3 newWorldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            transform.position = newWorldPosition;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                other.GetComponent<Thanh_DropThing>().OnHit();
            }
        }
    }

    

}
