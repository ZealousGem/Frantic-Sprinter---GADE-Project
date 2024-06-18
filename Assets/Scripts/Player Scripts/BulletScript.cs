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
        switch (gameObject.tag)
        {
            case "Bullet": AudioManager.instance.SFX("Laser"); break;
            case "destroy": AudioManager.instance.SFX("Gun"); break;
        }
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("destroy") || other.gameObject.CompareTag("Boss") || other.gameObject.CompareTag("Boss"))
        {
            switch (gameObject.tag)
            {
                case "Bullet": Destroy(other.gameObject); PointManager.points += 10; AudioManager.instance.SFX("Points"); break;
                    default: /*Destroy(other.gameObject)*/;  break;
            }
            
            // Debug.Log("Detroyed");
        }
    }
}
// https://www.youtube.com/watch?v=EwiUomzehKU