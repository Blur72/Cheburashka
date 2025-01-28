using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class EatSpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> spawnPoints;
    [SerializeField] private Transform eat;
    [SerializeField] private float timeSpawnStart;

    private float timeSpawn;
    void Start()
    {
        timeSpawn = timeSpawnStart;
    }

    void Update()
    {
        if(timeSpawn <= 0)
        {
            int randomSpawnPoint = Random.Range(0, spawnPoints.Count);
            Instantiate(eat, new Vector3(spawnPoints[randomSpawnPoint].position.x, spawnPoints[randomSpawnPoint].position.y, 0), Quaternion.identity);
            timeSpawn = timeSpawnStart;
        }
        else
        {
            timeSpawn -= Time.deltaTime;
        }
    }
}
