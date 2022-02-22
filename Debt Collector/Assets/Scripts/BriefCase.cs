using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BriefCase : MonoBehaviour
{
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Player PlayerObject = collision.collider.GetComponent<Player>();
        //PickUpObject ItemComponent = collision.collider.GetComponent<PickUpObject>();
        if(PlayerObject.IsHoldingObject)
        {
            //int value = ItemComponent.Value;
            PlayerObject.InsertItem(PlayerObject.HoldingObjectValue);

            Score.instance.AddCash();
        }
    }
}
