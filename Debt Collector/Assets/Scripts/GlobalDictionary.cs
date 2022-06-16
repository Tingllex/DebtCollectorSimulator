using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalDictionary : MonoBehaviour
{
    public Dictionary<string, int> itemWithValue = new();

    public Dictionary<string, int> getDictionary()
    {
        return itemWithValue;
    }
}
