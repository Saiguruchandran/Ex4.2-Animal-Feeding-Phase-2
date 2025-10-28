using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalprefabs;
    private float spawnRangex=10;
    private float spawnPosZ=10;
    private float startDelay=2;
    private float spawnInterval=1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        int animalIndex= Random.Range(0,animalprefabs.Length);
        Vector3 spawnPos =  new Vector3(Random.Range(-spawnRangex,spawnRangex),0,spawnPosZ);
        Instantiate(animalprefabs[animalIndex],spawnPos,animalprefabs[animalIndex].transform.rotation);
    }
}
