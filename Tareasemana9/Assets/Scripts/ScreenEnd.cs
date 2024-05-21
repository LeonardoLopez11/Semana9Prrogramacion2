using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenEnd : MonoBehaviour
{
    public float delayBeforeCredits = 2f; 

    void Start()
    {
        
        StartCoroutine(LoadCreditsSceneAfterDelay());
    }

    IEnumerator LoadCreditsSceneAfterDelay()
    {
        
        yield return new WaitForSeconds(delayBeforeCredits);
        Trophies.Unlock(233703);
        SceneManager.LoadScene("Credits");
    }
}
