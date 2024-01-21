using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Rigidbody2D arrowPrefab;
    public float speed = 2.5f;
    public int damage = 20; // Increased damage value
    public float knockbackForce = 5;
    public float range = 2;
    private float timer;

    void Start()
    {
        timer = range;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && timer <= 0)
        {
            ShootArrow();
            timer = range;
        }
    }

    void ShootArrow()
    {
        // Instantiate a new arrow Rigidbody2D
        Rigidbody2D newArrow = Instantiate(arrowPrefab, transform.position, Quaternion.identity);
        
        newArrow.transform.rotation = Quaternion.Euler(0, 0, 0);

        // Set velocity for the new arrow
        newArrow.velocity = Vector2.right * speed;

        // Destroy the arrow GameObject after a delay (range)
        Destroy(newArrow.gameObject, range);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyHealth>())
        {
            HandleEnemyCollision(collision.gameObject);
        }
    }

    void HandleEnemyCollision(GameObject enemy)
    {
        Debug.Log("Arrow hit enemy");
        enemy.GetComponent<Rigidbody2D>().AddForce(Vector2.right * knockbackForce, ForceMode2D.Impulse);
        enemy.GetComponent<EnemyHealth>().TakeDamage(damage);
    }
}
