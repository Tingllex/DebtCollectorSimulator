using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public int Value;
    private void OnCollisionEnter(Collision collision)
    {
        Player PlayerObject = collision.collider.GetComponent<Player>();
        if(!PlayerObject.IsHoldingObject)
        {
            PlayerObject.HoldingObjectValue = Value;
            PlayerObject.IsHoldingObject = true;
            Collider PickedObjectCollider = GetComponent<Collider>();
            gameObject.SetActive(false);
            PickedObjectCollider.enabled = false;
        }
    }
}
