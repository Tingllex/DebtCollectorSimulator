using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int itemValue;
    public bool isPositive;
    public string objectName;
    public string backgroundColor;
    private Dictionary<string, int> itemWithValue;
    public void Awake()
    {
        itemValue = Random.Range(-10, 10);
        GameObject go = GameObject.Find("ItemDescription");
        GlobalDictionary globalDictionary = go.GetComponent<GlobalDictionary>();
        itemWithValue = globalDictionary.getDictionary();
        objectName = gameObject.name.Remove(gameObject.name.Length-7);
        if (itemWithValue.ContainsKey(objectName))
            itemValue = itemWithValue[objectName];

        if (itemValue >= 0)
        {
            isPositive = true;
            backgroundColor = "green";
        }
        else
        {
            isPositive = false;
            backgroundColor = "red";
        }

        if (!itemWithValue.ContainsKey(objectName))
            itemWithValue.Add(objectName, itemValue);
    }
}
