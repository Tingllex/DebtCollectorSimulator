using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BriefCase : MonoBehaviour
{
    public static int CollectedCash;
    private void Start()
    {
        CollectedCash = 0;
    }
    void Update()
    {
        
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
