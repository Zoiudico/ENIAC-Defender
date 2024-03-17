using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{


    public GameObject Insect;
    public float timeSpawn;
    public Transform[] spawnPoint;

     
    public int totalScore;
    public Text scoreText;


    public static GameController instance;





    void Start()
    {
          instance = this;
  
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



    public void UpdateScoreText()
    {
     scoreText.text = totalScore.ToString();
    }

}
