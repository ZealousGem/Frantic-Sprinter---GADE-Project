using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Weapon Effect", menuName = "WeaponEffect Effect")]
public class WeaponEffect : PickUpPower
{
    // Start is called before the first frame update
    public static bool activateGun = false;
    public override void ActivateEffect(GameObject player, GameObject cap)
    {
        
        activateGun = true;
    }

    public override void RemoveEffect(GameObject player, GameObject cap)
    {
        activateGun = false;
    }
}
