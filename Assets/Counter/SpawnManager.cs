using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;

    private float spawnPosZ = 3;
    private float startDaley = 2;
    private float spawnInterval = 5.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar", startDaley, spawnInterval);
    }

    void Update()
    {

    }

    void SpawnRandomCar()
    {
        int animalIndex = Random.Range(0, carPrefabs.Length);

        Vector3 spawnPos = new Vector3(-44, 9.5f, Random.Range(-spawnPosZ, spawnPosZ));

        Instantiate(carPrefabs[animalIndex], spawnPos, carPrefabs[animalIndex].transform.rotation);
    }
}

