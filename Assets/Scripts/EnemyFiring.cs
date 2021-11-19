using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFiring : MonoBehaviour
{
    GameObject Player;
    public Transform Firepoint;

    public GameObject bullet;
    public float timeBetweenShots;
    public float MaxDist;

    float timestamp = 0f;

    void Start(){
        Player = GameObject.Find("Player");
    }
    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position,Player.transform.position) <= MaxDist && (Time.time > timestamp)) { 
            timestamp = Time.time + timeBetweenShots;
            Shoot();
             
        }
    }

    void Shoot(){
        Instantiate(bullet, Firepoint.position, Firepoint.rotation);
    }
}
