using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab2 : MonoBehaviour
{
    private bool hold;
    public Animator animator;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                animator.SetBool("isLeftHandUp", true);
                animator.SetBool("isMaxLeftHandUp", true);
            }
            else
            {
                animator.SetBool("isMaxLeftHandUp", false);
                animator.SetBool("isLeftHandUp", true);
            }
            hold = true;
        }
        else
        {
            animator.SetBool("isLeftHandUp", false);
            animator.SetBool("isMaxLeftHandUp", false);
            hold = false;
            Destroy(GetComponent<FixedJoint>());
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (hold && col.gameObject.CompareTag("Item"))
        {
            Rigidbody rb = col.transform.GetComponent<Rigidbody>();
            if (rb != null)
            {
                FixedJoint fj = transform.gameObject.AddComponent(typeof(FixedJoint)) as FixedJoint;
                fj.connectedBody = rb;
            }
            else
            {
                FixedJoint fj = transform.gameObject.AddComponent(typeof(FixedJoint)) as FixedJoint;
            }
        }
    }
}
