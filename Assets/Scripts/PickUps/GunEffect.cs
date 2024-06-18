using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Gun Effect", menuName = "PickUp/Gun Effect")]
public class GunEffect : PickUpPower
{
 
    public override void ActivateEffect(GameObject player, GameObject cap)
    {
        string tag = "Destroyer";
      
        cap.SetActive(true);
        player.tag = tag;

    
        
    }

    public override void RemoveEffect(GameObject player, GameObject cap)
    {
        string tag = "Player";
      
        cap.SetActive(false);
        AudioManager.instance.SFX("stop");
        player.tag = tag;
     
    }

}
// https://discussions.unity.com/t/renderer-material-color-changing-with-script/210878