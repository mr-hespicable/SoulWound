using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicEnemyHealth : MonoBehaviour
{
    //this is the script to manage the enemies health (can change health amount in editor)

    public int enemyMaxHealth = 10;
    public int enemyCurrentHealth;
    //reference animator

    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }


    void Update()
    {
        if (enemyCurrentHealth <= 0)
        {
            Destroy(gameObject);
            //play a die animation
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            EnemyTakeDamage(5);
        }
    }

    public void EnemyTakeDamage(int damage)
    {
        enemyCurrentHealth -= damage;
        //play a hurt animation
    }

}
