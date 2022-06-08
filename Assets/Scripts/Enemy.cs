using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool standardEnemy;
    public bool fastEnemy;
    public bool slowEnemy;

    public float enemyHealth = 100;
    public int cost;

    public float enemySpeed;
    public Vector2 direction;

    public GameObject deathEffect;
    public AudioClip death;

    LevelManager levelManager;
    PlayerStats playerStats;
    LevelWin levelWin;

    private void Start()
    {
        levelManager = GameObject.Find("GameMaster").GetComponent<LevelManager>();
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
        levelWin = GameObject.Find("GameMaster").GetComponent<LevelWin>();
    }

    private void Update()
    {
        if (levelWin.levelWin == true)
        {
            enemySpeed = 0;
        }
    }

    public void TakeDamage(float amout)
    {
        enemyHealth -= amout;

        if (enemyHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        GameObject e = Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(e, 4f);
        PlayerStats.money += cost;
        playerStats.enemyKill++;
        PlayerController.playerAudio.PlayOneShot(death);

        if (standardEnemy == true)
        {
            levelManager.killStandardEmemy++;
        }
        if (fastEnemy == true)
        {
            levelManager.killFastEnemy++;
        }
        if(slowEnemy == true)
        {
            levelManager.killSlowEnemy++;
        }
    }
}
