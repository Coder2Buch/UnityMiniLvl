using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSpawner : MonoBehaviour
{
    public GameObject PlantPrefab;
    public GameObject MushroomPrefab;
    //public GameObject FernPrefab;
    //public GameObject PlantainPrefab;


    //public Vector3 center;
    public Vector3 size;

	// Use this for initialization
	void Start ()
    {
        SpawnPlants();
        SpawnMushroom();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            SpawnPlants();
            SpawnMushroom();
        }
	}

    public void SpawnPlants()
    {
        Vector3 pos = transform.localPosition + new Vector3(Random.Range(-size.x / 2, size.x / 2),
                      Random.Range(-size.y / 2, size.y / 2),Random.Range(-size.z / 2, size.z / 2));
        Instantiate(PlantPrefab, pos, Quaternion.identity);
    }

    public void SpawnMushroom()
    {
        Vector3 pos = transform.localPosition + new Vector3(Random.Range(-size.x / 2, size.x / 2),
                      Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Instantiate(MushroomPrefab, pos, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
         Gizmos.color = Color.red;
         Gizmos.DrawCube(transform.localPosition, size);
    }
}
