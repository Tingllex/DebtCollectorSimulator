using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>().GetComponent<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        playerMovement.isGrounded = true;
    }
}
