using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PointManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int points { get; set; }
    public static int LoopPoints3 { get; set; }
    public Text Points;
    public Text Display;
    public Text LoopPoints;
   
    
    public UnityEvent PointEvent;
   // public UnityEvent LoopEvent;

    //int finalPoints = 0;
    void Start()
    {
        //  finalPoints = 0;




          LoopPoints3 = LoopCounter.Instance.getPoints();
          points = GlobalPoints.Instance.getPoints();
        



    }

    // Update is called once per frame
    void Update()
    {
       PointEvent?.Invoke();
       
               // Debug.Log(points);
    }

    public void PointDisplay()
    {
        Points.text = points.ToString();
        Display.text = Points.text;
        GlobalPoints.Instance.setPointsint(points);

    }

    public void LoopPointDisplay()
    {
        LoopPoints.text = LoopPoints3.ToString();
        LoopCounter.Instance.setPointsint(LoopPoints3);
    }
}
