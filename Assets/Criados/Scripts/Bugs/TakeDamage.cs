using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    

    void Start()
    {
        
    }

    void Update() 
    {
        
    }


    public void Destroying()
    {
        Object.Destroy(gameObject);
 
        GameController.instance.totalScore += 10;


    }
}
