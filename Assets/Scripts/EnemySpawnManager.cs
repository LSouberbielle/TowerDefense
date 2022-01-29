using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject EnemyToSpawn;
    public Transform SpawnPoint;
    public Transform EndPoint;
    public float SpawnFrequency = 1f;
    public float FirstSpawnTime = 1f;

    public void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), FirstSpawnTime, SpawnFrequency);
    }

    public void SpawnEnemy()
    {
        Enemy enemy = Instantiate(EnemyToSpawn, SpawnPoint.position, SpawnPoint.rotation).GetComponent<Enemy>();

        enemy.EndPoint = EndPoint;
    }
}
