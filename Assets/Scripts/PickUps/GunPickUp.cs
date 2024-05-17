using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    //GunEffect gun;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //  PickUpManager.power = gun;
            if (PickUpManager.bunAct != true)
            {
                PickUpManager.confirm = true;
                PickUpManager.gunAct = true;
            }
           
           
           
            Destroy(this.gameObject);
        }
    }


}
