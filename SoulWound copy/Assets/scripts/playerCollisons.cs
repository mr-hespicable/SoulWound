using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollisons : MonoBehaviour
{

    //this script manages the player's collisions, mostly in tandem with the player's health system

    public playerHealth playerHealth;


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            playerHealth.TakeDamage(5);
        }

        if (other.gameObject.tag == "enemy")
        {
            playerHealth.TakeDamage(5);
        }
    }
}
