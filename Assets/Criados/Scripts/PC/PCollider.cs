using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCollider : MonoBehaviour
{
    public int damage;

    public HealthManager hm;


    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bug")
        {
            hm.TakeDamage(damage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
