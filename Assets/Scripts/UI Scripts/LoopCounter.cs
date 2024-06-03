using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public static LoopCounter Instance { get; private set; }
    public int Looppoints { get; private set; }
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
        Looppoints = 0;
    }
    // Update is called once per frame
    public void setPointsint(int newPoints)
    {
        Looppoints = newPoints;
    }

    public int getPoints()
    {
        return Looppoints;
    }

    public void Reset()
    {
        Looppoints = 0;
    }
}
