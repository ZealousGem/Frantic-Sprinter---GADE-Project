using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

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

    public UnityEvent Pickup1;
    public UnityEvent PlayerPickup2;
    public UnityEvent StopPickups;
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
               Pickup1?.Invoke();
                
               // StopCoroutine(Pickup2());
            }
            
            //  Debug.Log("couritine");
            if (bunAct is true)
            {
               PlayerPickup2?.Invoke();   
                
               // StopCoroutine(Pickup());
            }
        }

        else
        {
            StopPickups?.Invoke();
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
       // Debug.Log("work");
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
       // Debug.Log("work");
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


    public void GunPickUp()
    {
        power = weapon;
        targetObject = capping;
        StartCoroutine(Pickup2());
    }

    public void InvPickUp()
    {
        power = invicble;
        targetObject = caps;
        StartCoroutine(Pickup());
    }

    public void Stop()
    {
        StopAllCoroutines();
    }
}
