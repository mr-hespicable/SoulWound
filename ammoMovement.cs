using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoMovement : MonoBehaviour
{

    //this script is used to move the player's ribbon attack through the scene and damages the enemies it finds

    public Rigidbody2D rb;
    public float ammoSpeed = 100;
    //reference animator

    void Start()
    {
        rb.velocity = transform.right * ammoSpeed;
        //play ribbon flying through air animation
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            basicEnemyHealth enemy = other.GetComponent<basicEnemyHealth>();
            if (enemy != null)
            {
                if (gameObject.tag == "small")
                {
                    enemy.EnemyTakeDamage(2);
                }
                if (gameObject.tag == "mid")
                {
                    enemy.EnemyTakeDamage(5);
                }
                if (gameObject.tag == "big")
                {
                    enemy.EnemyTakeDamage(10);
                }

            }
            Destroy(gameObject);
        }

    }


}
