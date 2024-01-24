using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth= 50;
   


    void Start()
    {
        health = maxHealth; // Pradiniame etape veikėjo sveikata priskiriama maksimaliai health

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        if(health <=0) // Tikrinama, ar objekto sveikata mažesnė arba lygi nuliui
        {
            Destroy(gameObject); // Jeigu taip, sunaikinamas objektas
        }
    }

    //Šis kodas apibrėžia objekto health 
    //Objektui priskiriama pradinė sveikata lygi maksimaliai sveikatai pradiniame etape.
    //Kiekvieno fiksuoto kadro metu tikrinama, ar objekto sveikata yra mažesnė arba lygi nuliui.
    //Jeigu sąlyga tenkinama, objektas yra sunaikinamas.
    

}
