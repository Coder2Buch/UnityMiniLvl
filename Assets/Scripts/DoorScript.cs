using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject open;
    public GameObject closed;

    public GameObject OpenPanel = null;

    private void OnTriggerEnter(Collider other)
    {
        OpenPanel.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        OpenPanel.SetActive(false);
        open.SetActive(false);
        closed.SetActive(true);
    }

    public bool IsOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }
     void Update()
    {
        if (IsOpenPanelActive)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OpenPanel.SetActive(false);
                open.SetActive(true);
                closed.SetActive(false);
            }
        }
    }
}
