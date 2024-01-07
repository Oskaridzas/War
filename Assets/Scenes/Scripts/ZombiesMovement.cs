using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D zombiebd;
    public int speed;

   

    // Update is called once per frame
    void Update()
    {
        zombiebd.velocity = Vector2.left*speed;
    }
}
