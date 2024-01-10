using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int damage = 25;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Health>())
        {
          collision.gameObject.GetComponent<Health>().health -= damage;
          Destroy(gameObject);
        }


    }
}
