using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        SpawnNewEnemy();
    }

    void OnEnable(){
        Enemy.OnEnemyKilled += SpawnNewEnemy;
    }
    public void SpawnNewEnemy(){
        int randomS = Mathf.RoundToInt(Random.Range(0f, spawnPoints.Length-1));
        int randomP = Mathf.RoundToInt(Random.Range(0f, enemies.Length-1));
        Instantiate(enemies[randomP], spawnPoints[randomS].position, Quaternion.identity);
    }
}
