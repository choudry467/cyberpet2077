using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallFlipPatch : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x < this.transform.position.x)
        {
            this.transform.localScale = new Vector3(-1f, this.transform.localScale.y, this.transform.localScale.z);
        }
        else
        {
            this.transform.localScale = new Vector3(1f, this.transform.localScale.y, this.transform.localScale.z);
        }
    }
}
