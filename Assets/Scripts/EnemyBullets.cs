using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        GameObject thePlayer = GameObject.Find("Player");
        GetComponent<Rigidbody2D>().velocity = ((Vector2)thePlayer.transform.position - (Vector2)transform.position).normalized * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo){
        PlayerMovement player = hitInfo.GetComponent<PlayerMovement>();
        if (player != null){
            player.Damage(10);
        }
        Destroy(gameObject);
    }
}
