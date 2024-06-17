using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //  PickUpManager.power = gun;
          
            if (PickUpManager.gunAct != true)
            {
                PickUpManager.confirm = true;
                AudioManager.instance.SFX("PowerUpPickup");
                PickUpManager.bunAct = true;
            }


            Destroy(this.gameObject);
        }
    }
}
