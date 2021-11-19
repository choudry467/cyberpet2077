using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    private bool working;
    void Start()
    {
        working = false;
    }

   
    void OnTriggerEnter2D (Collider2D hitInfo){
        PlayerMovement player = hitInfo.GetComponent<PlayerMovement>();
        if (working == true && player != null){
        SceneManager.LoadScene("GameOverComic");
        }
    }

    
    public void Fixed(){
        working = true;
    }


}
