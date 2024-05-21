using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenEnd : MonoBehaviour
{
    public float delayBeforeCredits = 5f; 

    void Start()
    {
        
        StartCoroutine(LoadCreditsSceneAfterDelay());
    }

    IEnumerator LoadCreditsSceneAfterDelay()
    {
        
        yield return new WaitForSeconds(delayBeforeCredits);
        
        SceneManager.LoadScene("Credits");
    }
}
