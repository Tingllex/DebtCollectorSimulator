using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool IsHoldingObject;
    private int CollectedCash;
    void Start()
    {
        CollectedCash = 0;
    }
    public void InsertItem()
    {
        IsHoldingObject = false;
        Debug.Log("InsertItemTest");
    }
}
