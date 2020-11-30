// Danny Gnaulati Collecting power up script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    // Declaring that the game object is a collectable
    // making the value of each collectable 1
    public GameObject collectable;
    public int coinValue = 1;

    // If the player comes into contact with this objects collider it will be destroyed
    // maiking the score chnage when the player hits the collectables collider
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PowerUpScore.instance.ChangeScore(coinValue);
            Debug.Log("I have hit" + other.tag);
            Destroy(collectable);
        }

    }


}

