// Danny Gnaulati Third Person Character Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacter : MonoBehaviour
{
    // How fast the player can move 
    public float Speed;

    void Update()
    {
        PlayerMovement();

    }

    // Allwoing the player to move in any direction
    // letting the player move with the camera
    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }

}



   



   
    
