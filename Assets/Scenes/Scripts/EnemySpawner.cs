using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    public GameObject  EnemyPrefab;
    public float spawnTime = 2;
    private float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <0)
        {
            SpawnEnemy();
        }
        
    }
    void SpawnEnemy()
    {
        Instantiate(EnemyPrefab, transform.position ,Quaternion.identity);
        
        timer = spawnTime;

    }
}
