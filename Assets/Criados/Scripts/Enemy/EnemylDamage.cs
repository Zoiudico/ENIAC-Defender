using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage;
    public HealthBar healthBar;

    // is called when a collision heappens
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ENIAC")
        {
            healthBar.TakeDamage(damage);
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
