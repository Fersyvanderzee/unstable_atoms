using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject systemPrefab;

    public float timeBetweenWaves;

    private float timeToSpawn = 2f;

    void Update(){
        
        if (Time.time >= timeToSpawn){
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    void SpawnBlocks(){
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++){
            if (randomIndex != i){
                Instantiate(systemPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }

}
