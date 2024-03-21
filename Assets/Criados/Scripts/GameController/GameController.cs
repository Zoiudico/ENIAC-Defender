using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject Insect;
    public float timeSpawn;
    public Transform[] spawnPoint;

    private float timer;
    public float timerLimit;

    public int totalScore;
    public static GameController instance;

    void Start()
    {
        InvokeRepeating("startSpawn", timeSpawn, timeSpawn);

        instance = this;
    
    }


    void Update()
    {
        timer = Time.deltaTime;

        if (timer >= timerLimit)
        {
            int spawnPointIndex = Random.Range(0, spawnPoint.Length);

            timer = 0;
        }
    }

    void startSpawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoint.Length);

       Instantiate(Insect,spawnPoint[spawnPointIndex].position, spawnPoint[spawnPointIndex].rotation);

    }

}
