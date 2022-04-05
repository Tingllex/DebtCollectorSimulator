using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private ConfigurableJoint hipJoint;
    [SerializeField] private Rigidbody hip;
    [SerializeField] private Animator targetAnimator;
    public bool isGrounded;
    private bool run = false;


    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.z, direction.x) * Mathf.Rad2Deg;
            this.hipJoint.targetRotation = Quaternion.Euler(0f, targetAngle, 0f);
            this.hip.AddForce(direction * this.speed);
            this.run = true;
        } else
        {
            this.run = false;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (isGrounded)
            {
                hip.AddForce(new Vector3(0, jumpForce, 0));
                isGrounded = false;
            }
        }
        this.targetAnimator.SetBool("Run", this.run);
    }
}
