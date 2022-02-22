using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool IsHoldingObject;
    public int CollectedCash;
    public int HoldingObjectValue;

    void Start()
    {
        CollectedCash = 0;
    }

    public void InsertItem(int ValueOfItem)
    {
        IsHoldingObject = false;
        CollectedCash += ValueOfItem;
        Debug.Log("CollectedCash" + CollectedCash);
        Debug.Log("ValueOfItem " + ValueOfItem);
    }
}
