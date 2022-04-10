using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyLimbShoulder : MonoBehaviour
{
    public Transform targetLimb;
    ConfigurableJoint m_ConfigurableJoint;
    Quaternion targetInitialRotation;
    void Start()
    {
        m_ConfigurableJoint = GetComponent<ConfigurableJoint>();
        targetInitialRotation = targetLimb.transform.localRotation;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        m_ConfigurableJoint.targetRotation = copyRotation();
    }

    private Quaternion copyRotation()
    {
        return Quaternion.Inverse(targetLimb.localRotation) * targetInitialRotation;
    }
}
