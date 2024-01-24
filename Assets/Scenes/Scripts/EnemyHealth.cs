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
        health = maxHealth; // Pradinėje funkcijoje nustatomas objekto sveikatos lygis pagal maksimalią sveikatą

        // Set the Movement component manually if needed
        SetMovementComponent(GetComponent<Movement>());     // Nustatoma Judėjimo komponento rankiniu būdu, jei reikia
    }

    public void SetMovementComponent(Movement movementComponent) //// Rankiniu būdu nustato Judėjimo komponentą, jei reikia
    {
        movement = movementComponent; // Nustatomas Judėjimo komponentas
    }

    

    public void TakeDamage(int damage) // Funkcija, skirta apdoroti damage
    {
        Debug.Log("Enemy taking damage: " + damage);
        health -= damage;// Atimama žala nuo priešo sveikatos

        if (health <= 0) // Tikrinama, ar priešo sveikata mažesnė arba lygi nuliui
        {
            StartCoroutine(DestroyEnemy()); // Jei taip, pradedamas priešo sunaikinimas
        }
        else
        {
            StartCoroutine(KnockbackDelay()); // Jei ne, inicijuojama atšokio atidėlio procedūra
        }
    }

    IEnumerator DestroyEnemy()
    {
        if (movement != null)
        {
            movement.enabled = false; //Išjungiamas Judėjimo komponentas
            yield return new WaitForSeconds(delayTime); //// Laukiama tam tikro laiko
        }

        Debug.Log("Enemy destroyed");
        Destroy(gameObject); //Sunaikinamas priešo objektas
    }

    IEnumerator KnockbackDelay()
    {
        
        yield return null;
    }
}




