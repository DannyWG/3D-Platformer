// Danny Gnaulati 3RD Person Camera Script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour

    // Camera Sensativity
    // Making sure the camera targets the player
{

    public float RotationSpeed = 1;
    public Transform Target, Player;
    float mouseX, mouseY;

    // This is so when the game is played you will not be able to see the mouse cursor
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    void LateUpdate()
    {
        CamControl();
    }

    // Making the camera rotate when the player moves there mouse
    // Making the camera track the player to wherever they go
    // pressing Left shiftwill allow the player to look around freely with the camera 
    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Target);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
            
        }
        else
        {


            Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
            Player.rotation = Quaternion.Euler(0, mouseX, 0);



        }

    }
}

   