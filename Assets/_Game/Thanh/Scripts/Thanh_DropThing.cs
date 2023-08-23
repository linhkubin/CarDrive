using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThanhDev
{
    public class Thanh_DropThing : MonoBehaviour
    {
        [SerializeField] private Rigidbody rb;

        public void OnHit()
        {
            this.rb.AddForce(Vector3.up * 100f - Vector3.forward * 10f);
            this.rb.useGravity = true;

            StartCoroutine(WaitToDestroy(gameObject));
        }

        IEnumerator WaitToDestroy(GameObject gO)
        {
            yield return new WaitForSeconds(4f);

            Destroy(gO);
        }
    }
}
