using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDescription : MonoBehaviour
{
    public ItemInfo item;
    void Start()
    {
        if(item.icon != null)
        {
            item.value = Random.Range(-10, 11);
        }
        else
            item.value = Random.Range(0, 11);
        //Debug.Log(item.name + item.value);
    }
}
