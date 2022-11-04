using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawnManager : MonoBehaviour
{
        public GameObject[] powerupPrefabs;
        private float spawnRangeX = 136f;
        private float spawnPosZ = 67f;
        private float startDelay = 1f;
        private float spawnInterval = 1f;

        void Start()
        {
            InvokeRepeating("SpawnRandomPowerup", startDelay, spawnInterval);
        }

        void Update()
        {
   
        }

        void SpawnRandomPowerup()
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int powerupIndex = Random.Range(0, powerupPrefabs.Length);
            Instantiate(powerupPrefabs[powerupIndex], spawnPos, powerupPrefabs[powerupIndex].transform.rotation);
        }

        private void Instantiate(GameObject powerupPrefab, float position, Quaternion instantiateInWorldSpace)
        {
            throw new System.NotImplementedException();
        }
}
