using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_manager : MonoBehaviour
{
    public GameObject[] animalPrefabs; //Array de prefabs
    private int animalIndex;
    private float spawnRangeX = 14f;
    private float spawnPosz = 15f;
    private float startDelay = 1.5f;
    private float spawnInterval = 2f;

    private void Start()
    {
        //Invoca animales periodicamente de manera aleatoria
        InvokeRepeating("spawnRandomAnimal", startDelay, spawnInterval);
    }


    //Función que genera una posición aleatoria
    private Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        return new Vector3(randomX, 0, spawnPosz);
    }
    
    //Funcion que hace aparecer de posición aleatoria un animal aleatorio.
    private void spawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], RandomSpawnPos(), animalPrefabs[animalIndex].transform.rotation);
    }
}
