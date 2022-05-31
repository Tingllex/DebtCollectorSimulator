using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Image icon;
    ItemInfo item;

    public void AddItem(ItemInfo newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
    }
}
