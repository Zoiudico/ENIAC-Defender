using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeslaShockim : MonoBehaviour
{

    public Transform point;
    public float radius;



    public LayerMask enemyLayer;
    

    void Start()
    {
        
    }

    void Update()
    {
        ShockWave();
    }


    #region Shokim

    void ShockWave()
    {
          Collider2D hit = Physics2D.OverlapCircle(point.position, radius,enemyLayer);
        if(hit!= null)
        {
            hit.GetComponent<TakeDamage>().Destroying();
            }

         


    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(point.position,radius);
    }




}




    #endregion
        
