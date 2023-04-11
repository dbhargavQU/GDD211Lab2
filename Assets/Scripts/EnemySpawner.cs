using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public int maxEnemies = 10;
    public BoxCollider spawnArea;

    private int numEnemies = 0;
    private float spawnTimer = 0f;

    private void Update()
    {
        // Check if we need to spawn a new enemy
        if (numEnemies < maxEnemies)
        {
            spawnTimer -= Time.deltaTime;

            if (spawnTimer <= 0f)
            {
                // Spawn a new enemy
                Vector3 spawnPosition = GetRandomSpawnPosition();
                Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
                numEnemies++;

                // Reset the spawn timer
                spawnTimer = spawnInterval;
            }
        }
    }

    private Vector3 GetRandomSpawnPosition()
    {
        Vector3 spawnPosition = Vector3.zero;
        spawnPosition.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
        spawnPosition.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
        spawnPosition.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);
        return spawnPosition;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(spawnArea.transform.position, spawnArea.bounds.size);
    }
}
