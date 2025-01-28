using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject projectilePrefab; // The projectile to shoot
    public float fireRate = 1f; // Shots per second
    public Transform firePoint; // Where projectiles spawn
    private float nextFireTime = 0f;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") && Time.time >= nextFireTime)
        {
            Shoot(other.transform);
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot(Transform enemy)
    {
        // Create a projectile and set its target
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
        projectile.GetComponent<Projectile>().SetTarget(enemy);
    }
}
