using System.Collections;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 8;
    public float delayTime = 0.15f;
    private Movement movement;

    void Start()
    {
        health = maxHealth;

        // Set the Movement component manually if needed
        SetMovementComponent(GetComponent<Movement>());
    }

    // Set the Movement component manually if needed
    public void SetMovementComponent(Movement movementComponent)
    {
        movement = movementComponent;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Any logic you want to add here...
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("Enemy taking damage: " + damage);
        health -= damage;

        if (health <= 0)
        {
            StartCoroutine(DestroyEnemy());
        }
        else
        {
            StartCoroutine(KnockbackDelay());
        }
    }

    IEnumerator DestroyEnemy()
    {
        if (movement != null)
        {
            movement.enabled = false;
            yield return new WaitForSeconds(delayTime);
        }

        Debug.Log("Enemy destroyed");
        Destroy(gameObject);
    }

    IEnumerator KnockbackDelay()
    {
        // Implement your knockback delay logic here
        yield return null;
    }
}




