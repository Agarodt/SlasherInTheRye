using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        target = PlayerController.instance.transform;
        transform.position = new Vector3(target.position.x - 30, target.position.y + 30, target.position.z - 30);
    }
 
}