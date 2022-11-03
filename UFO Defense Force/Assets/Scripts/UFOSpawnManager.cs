using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOSpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs;
    private float spawnRangeX = 25f;
    private float spawnPosZ = 30f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomUfo", startDelay, spawnInterval);
    }

    void Update()
    {
   
    }

    void SpawnRandomUfo()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0,spawnPosZ);
        int ufoIndex = Random.Range(0, ufoPrefabs.Length);
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation);
    }
}
