using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Rigidbody2D arrowRb;
    public float speed = 2.5f;
    public int damage=50;
    public float knockbackForce = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        arrowRb.velocity = Vector2.right * speed;

     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.gameObject.GetComponent<EnemyHealth>())
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * knockbackForce, ForceMode2D.Impulse);
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
            Destroy(gameObject);
        }


    }
}
