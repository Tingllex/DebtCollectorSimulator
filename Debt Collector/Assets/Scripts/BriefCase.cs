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
        if(PlayerObject.IsHoldingObject)
        {
            PlayerObject.InsertItem(PlayerObject.HoldingObjectValue);
        }
    }
}
