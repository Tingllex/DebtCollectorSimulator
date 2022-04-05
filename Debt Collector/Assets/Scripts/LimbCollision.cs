using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbCollision : MonoBehaviour
{
    public CharacterController characterController;
    void Start()
    {
        characterController = GameObject.FindObjectOfType<CharacterController>().GetComponent<CharacterController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        characterController.isGrounded = true;
    }
}
