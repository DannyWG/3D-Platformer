// Danny Gnaulati Jump Mechanic script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMechanic : MonoBehaviour
{
    public float jumpSpeed = 5f;
    public int defaultJumpAllowed = 1;
    int jumpAllowed;

    Rigidbody rig;
    bool isGrounded;

    // Declaring that we are using a rigidbody
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        jumpAllowed = defaultJumpAllowed;
    }

    //Double Jump
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                Jump();
                isGrounded = false;
            }
            else if (!isGrounded && jumpAllowed > 0)
            {
                Jump();
                jumpAllowed--;
            }
        }

    }
    // Normal Jump
    void Jump()
    {

        rig.AddForce(transform.up * jumpSpeed, ForceMode.VelocityChange);

    }


    // Checking to see if the player is on the ground to see if jumping is allowed
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            jumpAllowed = defaultJumpAllowed;
        }
    }

    // making sure the player cant jump forever
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }



}
