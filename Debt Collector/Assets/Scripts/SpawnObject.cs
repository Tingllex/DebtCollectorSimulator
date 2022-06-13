using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    public Vector3 center;
    public Vector3 size;
    public int numOfItemsToSpawn;
    //public static List<GameObject> spawnedItems = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numOfItemsToSpawn; i++)
            SpawnItem();
    }

    public void SpawnItem()
    {
        int randomIndex = Random.Range(0, itemPrefabs.Length);
        //spawnedItems.Add(itemPrefabs[randomIndex]);
        Vector3 position = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        Instantiate(itemPrefabs[randomIndex], position, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(center, size);
    }
}
