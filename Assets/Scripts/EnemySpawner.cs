using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to the enemy prefab
    public Transform spawnPoint;  // Where enemies spawn
    public Transform target;      // Target for the enemies to move toward
    public float spawnInterval = 2f; // Time between spawns

    void Start()
    {
        // Start spawning enemies at regular intervals
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Instantiate a new enemy at the spawn point
        GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        // Assign the target to the enemy
        enemy.GetComponent<Enemy>().target = target;
    }
}

