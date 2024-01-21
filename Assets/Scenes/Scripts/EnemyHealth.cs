using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 50;
    public float delayTime = 0.15f;
    public Movement movement;
    public Movement1 movement1;


    void Start()
    {
        health = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {


        
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        StartCoroutine(knockbackDelay());
    }
    IEnumerator knockbackDelay()
    {
        movement.enabled = false;
        movement1.enabled = false;
        yield return new WaitForSeconds(delayTime);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            movement.enabled = true;
            movement1.enabled = true;

        }
    }
}
