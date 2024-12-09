using UnityEngine;

public class SpawnMng : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 12;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInt = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInt);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpawnRandomAnimal() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}