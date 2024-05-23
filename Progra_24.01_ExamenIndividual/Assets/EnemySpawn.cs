using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public Transform spawnArea;
    public float initialSpawnDelay = 10f;
    public float spawnInterval = 60f;
    public float spawnIntervalIncreaseRate = 0.1f;
    public float minSpawnInterval = 5f;
    private float nextSpawnTime;

    public float timeUntilNextSpawn;

    void Start()
    {
        nextSpawnTime = Time.time + initialSpawnDelay;
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            UpdateSpawnInterval();
        }

        timeUntilNextSpawn = Mathf.Max(0f, nextSpawnTime - Time.time);
    }

    void OnDrawGizmos()
    {
        DrawSpawnAreaGizmo();
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = GetRandomSpawnPosition();
        Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);
        nextSpawnTime = Time.time + spawnInterval;
    }

    Vector3 GetRandomSpawnPosition()
    {
        float spawnX = Random.Range(spawnArea.position.x - spawnArea.localScale.x / 2f, spawnArea.position.x + spawnArea.localScale.x / 2f);
        float spawnZ = Random.Range(spawnArea.position.z - spawnArea.localScale.z / 2f, spawnArea.position.z + spawnArea.localScale.z / 2f);
        return new Vector3(spawnX, spawnArea.position.y, spawnZ);
    }

    void UpdateSpawnInterval()
    {
        spawnInterval *= (1f - spawnIntervalIncreaseRate);
        spawnInterval = Mathf.Max(spawnInterval, minSpawnInterval);
    }

    void DrawSpawnAreaGizmo()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(spawnArea.position, spawnArea.localScale);
    }
}
