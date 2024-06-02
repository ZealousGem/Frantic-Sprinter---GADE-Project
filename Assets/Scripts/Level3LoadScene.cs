using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
   
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           LoadScene2();
        }
    }

    public void LoadScene2()
    {

        /*SceneCounter.currentScene = scenes[1]; */
        SceneManager.LoadScene("MainLevel2"); Debug.Log("load"); /* SceneCounter.currentScene = scenes[0]; */

    }
}
