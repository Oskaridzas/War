using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public Rigidbody2D zombie;
    public float speed;
    


    // Update is called once per frame
    void FixedUpdate ()
    {
        
        zombie.velocity = Vector2.left * speed;

    }

    
}
