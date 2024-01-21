using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth= 50;
   


    void Start()
    {
        health = maxHealth;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        if(health <=0)
        {
            Destroy(gameObject);
        }
    }
    
}
