using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{

    public Rigidbody2D monster;
    public float speed;


    // Update is called once per frame
    void FixedUpdate()
    {

        monster.velocity = Vector2.left *speed;

    }
}
