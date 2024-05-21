using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerr : MonoBehaviour
{
    private int enemyCount;
    public bool Nivel2;

    void Start()
    {
        
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    public void EnemyKilled()
    {
        enemyCount--;
        if (enemyCount <= 0)
        {
            if (Nivel2)
            {
                LoadVictoryScene();
            }
            else
            {
                LoadNextLevel();
            }
        }
    }

    void LoadNextLevel()
    {
        Trophies.Unlock(233702);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    void LoadVictoryScene()
    {
        Trophies.Unlock(233086);
        SceneManager.LoadScene("Victory");
    }
}
