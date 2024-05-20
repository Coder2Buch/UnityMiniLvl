using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject Door;
 
    bool isOpened = false;
  
    void OnTriggerEnter(Collider other)
    {
        if (!isOpened)
        {
            Door.transform.position += new Vector3(-1f, 0, 0.78f);
            Door.transform.Rotate(0, -90, 0, Space.Self);
            isOpened = true;
        }
    }

}
