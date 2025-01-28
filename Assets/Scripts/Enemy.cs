// Adjust the speed in Enemy.cs and spawnInterval in EnemySpawner.cs to tweak gameplay.

using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f; // Speed of the enemy
    public Transform target; // Target the enemy moves toward

    void Update()
    {
        if (target != null)
        {
            // Move toward the target
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the enemy reached the base
        if (other.CompareTag("Base"))
        {
            // Add logic to reduce health or play an effect
            Destroy(gameObject);
        }
    }
}

