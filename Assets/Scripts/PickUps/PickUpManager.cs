using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    // Start is called before the first frame update

    
    public PickUpPower power;

    public GunEffect invicble;
    public WeaponEffect weapon;
    public float end = 10f;
    public static bool confirm = false;
    public static bool gunAct = false;
    public static bool bunAct = false;
    //public static ;
     public GameObject playerObject;
    public GameObject ObjectPlayer;
    public GameObject targetObject;
    public GameObject caps;
    public GameObject capping;
    void Start()
    {
        targetObject = caps;
        targetObject.SetActive(false);
        StopAllCoroutines();
        
    } 

    // Update is called once per frame
    void Update()
    {
        if (confirm) 
        {

            if (gunAct is true)
            {
                power = invicble;
                targetObject = caps;
                StartCoroutine(Pickup());
                
               // StopCoroutine(Pickup2());
            }
            
            //  Debug.Log("couritine");
            if (bunAct is true)
            {
                power = weapon;
                targetObject = capping;
                StartCoroutine(Pickup2());
                
               // StopCoroutine(Pickup());
            }
        }

        else
        {
            StopAllCoroutines();
        }


        

        

       
        
    }

    public IEnumerator Pickup()
    {
        // power = invicble;
        // GameObject player = GameObject.FindGameObjectWithTag("Player").gameObject;
      
       
        GameObject player = playerObject;
        // Debug.Log("work");
        //  float time = 0f;

        // time += Time.deltaTime;
        Debug.Log("work");
        ActivatePickUp(player);
       // Debug.Log("working");
            yield return new WaitForSeconds(end);
            DeactivatePickUp(player);
            confirm = false;
            gunAct = false;
            bunAct = false;





    }

    public IEnumerator Pickup2()
    {
        // power = invicble;
        // GameObject player = GameObject.FindGameObjectWithTag("Player").gameObject;

        GameObject player = playerObject;
        // Debug.Log("work");
        //  float time = 0f;

        // time += Time.deltaTime;

        ActivatePickUp(player);
        Debug.Log("work");
        // Debug.Log("working");
        yield return new WaitForSeconds(end);
        DeactivatePickUp(player);
        confirm = false;
        gunAct = false;
        bunAct = false;





    }

    public void ActivatePickUp(GameObject player)
    {
        power.ActivateEffect(player, targetObject);
    }

    public void DeactivatePickUp(GameObject player)
    {
        
        power.RemoveEffect(player, targetObject);
    }
}
