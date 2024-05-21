using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigos : MonoBehaviour
{
    public int maxHealth = 50;
    private int currentHealth;
    private LevelManagerr levelManager;

    void Start()
    {
        currentHealth = maxHealth;
        levelManager = FindObjectOfType<LevelManagerr>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Trophies.Unlock(233082);
        levelManager.EnemyKilled();
        Destroy(gameObject);
    }
}
