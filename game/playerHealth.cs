using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    //possibly most important script:
    //this script manages the one and only player's health (IK CRZY)
    //also manages checkpoints and respawns :D

    public Transform checkpointLocation;
    public int maxHealth = 30;
    public int currentHealth;
    //reference animator (vry imprtnt)

    public healthBar healthBar;


    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.H))
        {
            AddHealth(20);
        }

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth <= 0)
        {
            Respawn(checkpointLocation);
        }

        //add a function that adds a vingnette and obnoxious noise when player is rlly low on health
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        //add player hurt animation
    }

    public void AddHealth(int health)
    {
        currentHealth += health;
        healthBar.SetHealth(currentHealth);
        //add player heal animation
    }

    //might make this a co-routine
    public void Respawn(Transform Loc)
    {
        //add player die animation
        gameObject.transform.position = Loc.position;
        currentHealth = maxHealth;
        healthBar.SetHealth(currentHealth);
        //add player respawn animation
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "checkpoint")
        {
            checkpointLocation = other.GetComponent<Transform>();
            currentHealth = maxHealth;
            healthBar.SetHealth(currentHealth);
            //maybe play some sort of like checkpoint got animation idk
        }

    }

}
