using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static TimeManager Instance { get; private set; }

    public int timer { private set; get; }

    float timer2;
    
    

    
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    

    // Update is called once per frame
    void Update()
    {
            
            timer2 += Time.deltaTime;
            timer = (int)timer2;
            
        
    }

    private void Start()
    {
        timer = 0;
    }

    public float GetTme()
    {
        return timer;
    }


    public void Reset()
    {
        timer2 = 0;
        timer = (int)timer2;
      
       
    }
}
