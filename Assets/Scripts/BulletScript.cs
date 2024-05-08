using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    float time = 3f;
    float timer = 0f;
    private void Awake()
    {
        
            Destroy(gameObject, time);
          
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("destroy"))
        {
            Destroy(other.gameObject);
            // Debug.Log("Detroyed");
        }
    }
}
// https://www.youtube.com/watch?v=EwiUomzehKU