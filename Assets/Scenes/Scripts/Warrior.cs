using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    public GameObject WarriorPrefab;
    public float cooldown = 2.5f;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            Instantiate(WarriorPrefab, transform.position, Quaternion.identity);
            timer = cooldown;


        }
        timer -= Time.deltaTime;
    }
}
