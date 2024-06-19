using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class despawn : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (other.gameObject.tag is "destroy")
        {
            PointManager.points += 1; // increases everytime an obstable is destroyed
        }
       
        // Debug.Log("Detroyed");
    }
}
