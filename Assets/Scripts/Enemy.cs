using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public delegate void EnemyKilled();
    public static event EnemyKilled OnEnemyKilled;
    public GameObject scrap;
    public void TakeDamage (int damage){
        health -= damage;
        if (health <= 0){
            Die();
        }
    }

    private void Die(){
        Destroy(gameObject);
        Instantiate(scrap, transform.position, Quaternion.identity);
        if (OnEnemyKilled != null){
            OnEnemyKilled();
        }
    }

}
