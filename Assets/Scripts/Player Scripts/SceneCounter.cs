using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneCounter : MonoBehaviour
{
    string[] scenes = { "MainLevel2", "MainLevel3" };


    public void LoadScene1()
    {

        GameEvent.TriggerLoadScene(scenes[1]); Debug.Log("load"); /*SceneCounter.currentScene = scenes[1]; */
        /* SceneCounter.currentScene = scenes[0]; */

    }
   
}
