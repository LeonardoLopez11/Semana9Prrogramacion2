using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.UI;
using GameJolt.API;
using UnityEngine.SceneManagement;

public class GameJ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameJoltUI.Instance.ShowSignIn((bool success) =>
        {
            if (success)
            {
                Debug.Log("Login successful!");
                UnlockTrophy();
                SceneManager.LoadScene("Level1");
            }
            else
            {
                Debug.Log("Login failed!");
            }
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UnlockTrophy()
    {
        Trophies.Unlock(233085);
    }
    
}
