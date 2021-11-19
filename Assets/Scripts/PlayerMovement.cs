using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 400f;
    float horizontalMove = 0f;
    bool jump = false;
    public Animator animator;
    
    public int scraps = 10;

    public HealthBar heal;

    public CollectBar col;
    public int maxHealth = 100;
    int currHealth;
    // Update is called once per frame
    public AudioSource jumpSound;

    public Teleporter telScript;

    private void Start()
    {
        currHealth = maxHealth;
        heal.SetMaxHealth(maxHealth);
        col.Initial();
    }
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        if(horizontalMove != 0)
        {
            animator.SetBool("Moving", true);
        }
        else
        {
            animator.SetBool("Moving", false);
        }
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("IsFlying2");
            jump = true;
            jumpSound.Play();
        }
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove* Time.fixedDeltaTime, jump, runSpeed);
        jump = false;

    }

    public void Damage(int damage){
        currHealth -= damage;
        heal.SetHealth(currHealth);
    }

    public void Collect(){
        if (scraps > 0){
            scraps--;
            col.Collected(10-scraps);
        }else
            telScript.Fixed();

    }
}
