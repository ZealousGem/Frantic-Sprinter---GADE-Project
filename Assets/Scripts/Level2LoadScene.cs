using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level2LoadScene : MonoBehaviour
{

   
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LoadScene1();
        }
    }

    public void LoadScene1()
    {

        SceneManager.LoadScene("MainLevel3"); Debug.Log("load");
        PointManager.LoopPoints3 += 1;/*SceneCounter.currentScene = scenes[1]; */
        /* SceneCounter.currentScene = scenes[0]; */

    }
}
