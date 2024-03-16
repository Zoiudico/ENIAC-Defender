using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
<<<<<<< Updated upstream

    public GameObject Insect;
    public float timeSpawn;
    public Transform[] spawnPoint;

    void Start()
    {
       InvokeRepeating("startSpawn", timeSpawn, timeSpawn);
=======
    public int totalScore;


    public static GameController instance;





    void Start()
    {
        instance = this;
>>>>>>> Stashed changes
    }

    void Update()
    {
        
    }
<<<<<<< Updated upstream

    void startSpawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoint.Length);

       Instantiate(Insect,spawnPoint[spawnPointIndex].position, spawnPoint[spawnPointIndex].rotation);

    }
=======
>>>>>>> Stashed changes
}
