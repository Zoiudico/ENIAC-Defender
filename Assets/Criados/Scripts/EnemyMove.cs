using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    float directionA;
    float directionB;
    public float speed = 10;
    float timer;
    public float timerLimit = 10;

    // Start is called before the first frame update
    void Start()
    {
        speed = speed / 1000f;
        directionA = Random.Range(-1, 1);
        directionB = Random.Range(-1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(directionA * speed, directionB * speed, 0f);
        timer += Time.deltaTime;
        MudarDireção();
    }

    void MudarDireção()
    {
        if (timer >= timerLimit)
        {
            directionA = Random.Range(-1, 2);
            directionB = Random.Range(-1, 2);
            timer = 0f;
        }
    }
}
