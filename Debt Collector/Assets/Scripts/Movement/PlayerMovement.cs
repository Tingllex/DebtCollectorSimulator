using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float sideSpeed;
    public float jumpForce = 1000f;
    public Rigidbody rb;
    public bool isGrounded;
    public ParticleSystem dust;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        /*if (Input.GetKey(KeyCode.Space))
        {
            if (isGrounded)
            {
                rb.AddForce(new Vector3(0, jumpForce, 0));
                isGrounded = false;
            }
        }*/

        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("isWalking", true);
                animator.SetBool("isRunning", true);
                rb.AddForce(rb.transform.forward * speed * 1.5f);
                if (isGrounded)
                {
                    CreateDust();
                }
            }
            else
            {
                animator.SetBool("isWalking", true);
                animator.SetBool("isRunning", false);
                rb.AddForce(rb.transform.forward * speed);
                if (isGrounded)
                {
                    CreateDust();
                }
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isMovingLeft", true);
            rb.AddForce(-rb.transform.right * sideSpeed);
        }
        else
        {
            animator.SetBool("isMovingLeft", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isWalking", true);
            rb.AddForce(-rb.transform.forward * sideSpeed);
        }
        else if(!Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isMovingRight", true);
            rb.AddForce(rb.transform.right * sideSpeed);
        }
        else
        {
            animator.SetBool("isMovingRight", false);
        }
    }

    void CreateDust()
    {
        dust.Play();
    }
}

