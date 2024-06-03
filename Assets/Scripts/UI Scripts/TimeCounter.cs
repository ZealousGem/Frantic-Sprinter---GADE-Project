using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    // Start is called before the first frame update
    private float timmy;
    public int timer;
    public static int bridge;
    public Text no;
    public Text yes;
    [SerializeField] private GameOverMenu gameOverMenu;

    // Update is called once per frame
    private void Start()
    {
        timmy = 0.0f;
        timer = 0;
    }
    void Update()
    {
        if (gameOverMenu.isActive is false)
        {
            
            timmy +=  Time.deltaTime;
            timer = (int)(timmy);
            bridge = timer;
            Debug.Log(bridge);
            no.text = TimeManager.Instance.GetTme().ToString();
            Debug.Log(timer.ToString());

        }

        else
        {
            no.text = TimeManager.Instance.GetTme().ToString();
            no.enabled = false;
            yes.enabled = false;
        }
           
        
    }

    // https://discussions.unity.com/t/how-to-make-a-timer-that-counts-up-in-seconds-as-an-int/147546/5 
}
