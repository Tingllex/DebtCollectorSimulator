using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BriefCase : MonoBehaviour
{
    public static int CollectedCash;
    public Transform target;

    private void Start()
    {
        CollectedCash = 0;
    }
    void Update()
    {
        var dir = target.position - transform.position;
        Quaternion LookAtRotation = Quaternion.LookRotation(dir);
        Quaternion OnlyYAxis = Quaternion.Euler(transform.rotation.eulerAngles.x, LookAtRotation.eulerAngles.y + 90, transform.rotation.eulerAngles.z);
        transform.rotation = OnlyYAxis;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Player PlayerObject = collision.collider.GetComponent<Player>();
        if(collision.gameObject.CompareTag("Item"))
        {
            Item lItem = collision.gameObject.GetComponent<Item>();
            if (lItem != null)
            {
                CollectedCash += lItem.ItemValue;
            }
            Destroy(collision.gameObject);
            Debug.Log("CollectedCash " + CollectedCash);
        }
        Debug.Log("kolizja!");
    }
}
