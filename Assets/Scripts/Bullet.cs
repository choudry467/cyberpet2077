using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        GameObject thePlayer = GameObject.Find("Player");
        PlayerAimWeapon aimScript = thePlayer.GetComponent<PlayerAimWeapon>();
        rb.velocity =  new Vector2(aimScript.aimDirection.x, aimScript.aimDirection.y) * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo){
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null){
            enemy.TakeDamage(25);
        }
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
