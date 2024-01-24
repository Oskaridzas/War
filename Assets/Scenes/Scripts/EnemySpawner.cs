using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    public GameObject  EnemyPrefab;
    public float spawnTime = 2;
    private float timer;
    
    void Start()
    {
        timer = spawnTime; ; // Pradiniame etape nustatoma laiko vertė lygi priešo atsiradimo intervalui

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; // Sumažinama laikmatis kiekvieno kadro metu

        if (timer <0) // Tikrinama, ar praėjo pakankamai laiko nuo paskutinio priešo atsiradimo
        {
            SpawnEnemy(); // Iškviečiama funkcija, kuri atsakinga už priešo atsiradimą
        }
        
    }
    void SpawnEnemy()
    {
        Instantiate(EnemyPrefab, transform.position ,Quaternion.identity); // Sukuriamas naujas priešo objektas pagal nurodytą prefaba

        timer = spawnTime; //Nustatomas naujas laikmatis lygus priešo atsiradimo intervalui

    }
}
