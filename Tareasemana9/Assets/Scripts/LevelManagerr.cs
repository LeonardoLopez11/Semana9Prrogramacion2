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
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    void LoadVictoryScene()
    {
        SceneManager.LoadScene("Victory");
    }
}
