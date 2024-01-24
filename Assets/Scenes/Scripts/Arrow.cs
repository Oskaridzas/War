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
        timer = range; // Pradiniame etape nustatoma laiko vertė lygi maksimaliam nuotoliui
    }

    void Update()
    {
        timer -= Time.deltaTime; // Sumažinama laikmatis kiekvieno kadro metu

        if (Input.GetKeyDown(KeyCode.Space) && timer <= 0)  //Tikrinama, ar paspaustas mygtukas "Space" ir praėjo pakankamai laiko nuo paskutinio šūvio
        {
            ShootArrow(); //Iškviečiama funkcija šūvio atlikimui
            timer = range; //Nustatomas naujas laikmatis lygus maksimaliam nuotoliui
        }
    }

    void ShootArrow()
    {
        // Instantiate a new arrow Rigidbody2D
        Rigidbody2D newArrow = Instantiate(arrowPrefab, transform.position, Quaternion.identity);    // Sukuriamas naujas RigidBody2D tipo objektas (strėlė)

        newArrow.transform.rotation = Quaternion.Euler(0, 0, 0); // Nustatoma strėlės sukimosi kampas

        // Set velocity for the new arrow
        newArrow.velocity = Vector2.right * speed;     // Nustatoma naujos strėlės greitis

        // Destroy the arrow GameObject after a delay (range)
        Destroy(newArrow.gameObject, range);     // Naikinamas strėlės objektas po tam tikro laiko (nuotolio)
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyHealth>()) // Tikrinama, ar susidūrimo objektas turi EnemyHealth komponentą
        {
            HandleEnemyCollision(collision.gameObject); // Iškviečiama funkcija, kuri apdoroja susidūrimą su priešu
        }
    }

    void HandleEnemyCollision(GameObject enemy)
    {
        Debug.Log("Arrow hit enemy"); //("Strėlė pataikė į priešą");
        enemy.GetComponent<Rigidbody2D>().AddForce(Vector2.right * knockbackForce, ForceMode2D.Impulse); // Priešui taikomas atstumas po strėlės pataikymo
        enemy.GetComponent<EnemyHealth>().TakeDamage(damage);  // Priešui taikoma damage pagal nustatytą  lygį

        //Šis kodas apibrėžia scriptą, kuris leidžia šaudyti strėlėmis žaidėjo valdomu objektu.
        //Strėlės turi greitį, damage, atstumą ir maksimalų nuotolį.
        //Jeigu strėlė pataiko priešą, jai taikomas atstumas ir priešas patiria nustatytą damage.
        //Žaidėjas gali šaudyti tik tam nustatytu intervalu.
    }
}
