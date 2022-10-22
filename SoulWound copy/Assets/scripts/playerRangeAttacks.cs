using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRangeAttacks : MonoBehaviour
{
    //this script creates the respective range attack and damages the player accordingly
    public playerHealth playerHealth;

    public Transform firepoint;

    public GameObject smallAttackAmmo;
    public GameObject midAttackAmmo;
    public GameObject bigAttackAmmo;

    //reference animator


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            smallShoot();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            midShoot();
        }
        if (Input.GetButtonDown("Fire3"))
        {
            bigShoot();
        }
    }

    void smallShoot()
    {
        Instantiate(smallAttackAmmo, firepoint.position, firepoint.rotation);
        playerHealth.TakeDamage(1);
        //add logic to see how much health the character has (if (playerHealth.currentHealth) <= num)

        //add small shooting animation (small character)
        //add small shooting animation (medium character)
        //add small shooting animation (big character)
    }
    void midShoot()
    {
        Instantiate(midAttackAmmo, firepoint.position, firepoint.rotation);
        playerHealth.TakeDamage(3);
        //add logic to see how much health the character has (if (playerHealth.currentHealth) <= num)

        //add medium shooting animation (medium character)
        //add medium shooting animation (big character)
    }
    void bigShoot()
    {
        Instantiate(bigAttackAmmo, firepoint.position, firepoint.rotation);
        playerHealth.TakeDamage(5);
        //add logic to see how much health the character has (if (playerHealth.currentHealth) <= num)

        //add big shooting animation (big character)
    }
}
