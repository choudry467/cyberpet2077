using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrap : MonoBehaviour
{
     void OnTriggerEnter2D (Collider2D hitInfo){
        Debug.Log(hitInfo); 
        PlayerMovement player = hitInfo.GetComponent<PlayerMovement>();
        if (player != null){
            player.Collect();
            Destroy(gameObject);
        }
     }
}
