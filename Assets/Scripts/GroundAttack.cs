using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;

    void OnTriggerEnter2D (Collider2D hitInfo){
        
        
        
        PlayerMovement player = hitInfo.GetComponent<PlayerMovement>();
        if (player != null){
            //pushback
            int x=1;
            GameObject playerp = GameObject.Find("Player");
            if (playerp.transform.position.x > this.transform.position.x)
                x=-1;
            rb.AddForce(new Vector2(x*5000f, 0f));



            player.Damage(10);
        }
    }
}
