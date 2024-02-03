
using UnityEngine;
using System.Collections.Generic;

public class PointsSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] SpawnLocations;
    //[SerializeField] private Transform[] currentlySpawned;
    [SerializeField] private List<Transform> currentlySpawned = new List<Transform>();
    [SerializeField] private List<float> curSpawnZVal = new List<float>();
    public GameObject prefab;
    void Start()
    {
        for (var i = 0; i < 15; i++)
        {
            Transform SpawnLoc = SpawnLocations[Random.Range(0, SpawnLocations.Length)];
            
            while (curSpawnZVal.Contains(SpawnLoc.position.z))
            {
                Debug.Log("new one");
                SpawnLoc = SpawnLocations[Random.Range(0, SpawnLocations.Length)];
            }
            GameObject Clone = Instantiate(prefab, SpawnLoc.position, new Quaternion(0f, 0f, Random.Range(0f, 180f), 180f));

            currentlySpawned[i] = Clone.transform;
            curSpawnZVal.Add(Clone.transform.position.z);
        }
    }

    public void SpawnObject()
    {
        Transform SpawnLoc = SpawnLocations[Random.Range(0, SpawnLocations.Length)];
        while (curSpawnZVal.Contains(SpawnLoc.position.z))
        {
            SpawnLoc = SpawnLocations[Random.Range(0, SpawnLocations.Length)];
        }
        GameObject Clone = Instantiate(prefab, SpawnLoc.position, new Quaternion(0f, 0f, Random.Range(0f, 180f), 180f));
        curSpawnZVal.Add(Clone.transform.position.z);
    }
}