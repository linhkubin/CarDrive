using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class CleanerCtrl : MonoBehaviour
{
    Transform tf;
    [SerializeField] private Camera mainCamera;

    private void Start()
    {
        tf = transform;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetMouseButton(0))
            {
                Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast(ray, out hitInfo))
                {
                    Vector3 targetPosition = hitInfo.point;
                    targetPosition.z = tf.position.z;
                    tf.position = Vector3.Lerp( tf.position,targetPosition, 0.3f);

                }
            }
        }
    }
}
