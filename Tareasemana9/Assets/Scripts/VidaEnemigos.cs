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
        levelManager.EnemyKilled();
        Destroy(gameObject);
    }
}
