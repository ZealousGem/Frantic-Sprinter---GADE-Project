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
        if (PointManager.LoopPoints3 >= 2)
        {
            string[] pickOne = new string[] { "1", "2" };
            int picked = Random.Range(0, pickOne.Length);
            switch (pickOne[picked])
            {
                case "1":
                    SceneManager.LoadScene("MainLevel2"); Debug.Log("load"); /* SceneCounter.currentScene = scenes[0]; */
                    PointManager.LoopPoints3 += 1; break;
                case "2":
                    SceneManager.LoadScene("MainLevel3"); Debug.Log("load"); /* SceneCounter.currentScene = scenes[0]; */
                    PointManager.LoopPoints3 += 1; break;
            }

        }
        else
        {
            SceneManager.LoadScene("MainLevel3"); Debug.Log("load");
            PointManager.LoopPoints3 += 1;
        }
        /*SceneCounter.currentScene = scenes[1]; */
        /* SceneCounter.currentScene = scenes[0]; */

    }
}
