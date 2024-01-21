// Warrior.cs
// Warrior.cs
using System.Collections;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    public Script arrowPrefab;
    public float cooldown = 2.5f;
    private bool canShoot = true;

    void Update()
    {
        if (canShoot)
        {
            StartCoroutine(ShootArrowWithCooldown());
        }
    }

    IEnumerator ShootArrowWithCooldown()
    {
        canShoot = false; // Prevent shooting during cooldown
        Instantiate(arrowPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(cooldown);
        canShoot = true; // Allow shooting after cooldown
    }
}
