using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject Insect;
    public float timeSpawn;
    public Transform[] spawnPoint;

    void Start()
    {
       InvokeRepeating("startSpawn", timeSpawn, timeSpawn);
    }

    void Update()
    {
        
    }

    void startSpawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoint.Length);

       Instantiate(Insect,spawnPoint[spawnPointIndex].position, spawnPoint[spawnPointIndex].rotation);

    }
}
