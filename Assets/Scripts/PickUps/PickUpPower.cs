using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUpPower : ScriptableObject
{
    // Start is called before the first frame update
    public abstract void ActivateEffect(GameObject player, GameObject cap);




    public abstract void RemoveEffect(GameObject player, GameObject cap);
    
}
