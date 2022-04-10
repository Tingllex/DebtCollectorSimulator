using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyLimb : MonoBehaviour
{
    public Transform targetLimb;
    ConfigurableJoint m_ConfigurableJoint;

    void Start()
    {
        m_ConfigurableJoint = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        m_ConfigurableJoint.targetRotation = targetLimb.rotation;
    }

}
