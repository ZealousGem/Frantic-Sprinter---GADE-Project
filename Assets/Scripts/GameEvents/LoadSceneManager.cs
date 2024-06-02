using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
 
    private void OnEnable()
    {
        GameEvent.LoadScene += LoadScene;
    }

    private void OnDisable()
    {
        GameEvent.LoadScene -= LoadScene;
    }

    void LoadScene(string sceneName)
    {
        Debug.Log("Loading");
        SceneManager.LoadScene(sceneName);
    }
}
