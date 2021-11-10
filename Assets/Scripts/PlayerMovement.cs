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
    //Tests

    public HealthBar heal;
    public int maxHealth = 100;
    public int currHealth;
    // Update is called once per frame
    public AudioSource jumpSound;

    private void Start()
    {
        currHealth = maxHealth;
        heal.SetMaxHealth(maxHealth);
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
            currHealth -= 10;
            heal.SetHealth(currHealth);
            jumpSound.Play();
        }
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove* Time.fixedDeltaTime, jump, runSpeed);
        jump = false;

    }
}
