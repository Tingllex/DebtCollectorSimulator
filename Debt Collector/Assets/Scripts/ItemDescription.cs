using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDescription : MonoBehaviour
{
    public ItemInfo item;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(item.name);
    }
}
