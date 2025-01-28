using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 5f;
    private Transform target;

    public void SetTarget(Transform enemyTarget)
    {
        target = enemyTarget;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        // Move toward the target
        Vector3 direction = (target.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        // Destroy when close to the target
        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            Destroy(target.gameObject); // Destroy the enemy
            Destroy(gameObject); // Destroy the projectile
        }
    }
}
