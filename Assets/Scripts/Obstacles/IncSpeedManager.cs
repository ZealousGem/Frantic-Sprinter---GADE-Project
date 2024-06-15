using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncSpeedManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static IncSpeedManager Instance { get; private set; }
    public float Speedpoints { get; private set; }
    public float freqpoints { get; private set; }
    public float freqpoints2 { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { Destroy(gameObject); }
    }
    private void Start()
    {
        Speedpoints = 10;
      
    }
    // Update is called once per frame
    public void setPointsint(float newPoints)
    {
        Speedpoints = Speedpoints + newPoints;
    }

    public void setFreq(float newFreq)
    {
        freqpoints += newFreq;
        freqpoints2 += newFreq;
    }

    public float getFreq()
    {
        return freqpoints;
    }

    public float getFreq2()
    {
        return freqpoints2;
    }

    public float getPoints()
    {
        return Speedpoints;
    }

    public void Reset()
    {
        Speedpoints = 10;
        
    }
}
