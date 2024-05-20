using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSpawner_Other : MonoBehaviour
{
    public Vector3 size;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawCube(transform.localPosition, size);
    }
}
