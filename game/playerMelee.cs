using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMelee : MonoBehaviour
{
    public playerHealth playerHealth;
    //reference animator

    public int damageNum = 0;
    public int playerDamageNum = 0;

    public Transform attackPoint;
    public float attackRange = 1f;
    public LayerMask enemies;

    //add corresponding values for mid and big
    public float attackRate = 2f;
    float nextAttackTime = 0f;

    // Update is called once per frame
    void Update()
    {
        //add a thing that checks if player health is small mid or big :D (by using the player health
        //currentHealth variable)

        //small
        damageNum = Random.Range(0, 2);
        playerDamageNum = Random.Range(2, 3);
        //mid

        //big

        if (Time.time >= nextAttackTime)
        {
            //u can change attack button senpai (uwu)
            if (Input.GetKeyDown(KeyCode.G))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Attack()
    {
        //play attack animation
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemies);
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<basicEnemyHealth>().EnemyTakeDamage(5);
        }
        playerHealth.TakeDamage(playerDamageNum);
    }

    //dis to view range in editor
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
