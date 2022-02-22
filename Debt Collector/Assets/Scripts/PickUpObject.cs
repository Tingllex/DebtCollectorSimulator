using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Player PlayerObject = collision.collider.GetComponent<Player>();
        PlayerObject.IsHoldingObject = true;
        Collider PickedObjectCollider = GetComponent<Collider>();
        gameObject.SetActive(false);
        PickedObjectCollider.enabled = false;
    }
}
