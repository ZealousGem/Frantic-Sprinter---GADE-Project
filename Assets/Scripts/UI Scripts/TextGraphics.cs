using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class TextGraphics : MonoBehaviour
{
    // Start is called before the first frame update

    public Text boss;
    bool change = false;

    // Update is called once per frame
    private void Start()
    {
        boss.text = "BOSS INCOMING!!!";
       
    }
    void Update()
    {
        if (GameOverMenu.bossy == true || PauseMenu.isPaused == true)
        {
            boss.text = "";
        }

        else
        {
            
            boss.text = "BOSS INCOMING!!!";
            if (change)
            {
                //changeYellow();

                StartCoroutine(changeYellow());
            }

            else
            {
                StartCoroutine(changeRed());
            }
        }
           

        
        // StartCoroutine(change());
       
        
       
    }
    public IEnumerator changeRed()
    {
        boss.color = Color.red;
        yield return new WaitForSeconds(0.3f);
        change = true;
    }
    public IEnumerator changeYellow()
    {
        boss.color = Color.yellow;
        yield return new WaitForSeconds(0.3f);
        change = false;
    }
}

 

