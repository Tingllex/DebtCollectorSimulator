using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Security.Cryptography;

public class Slot : MonoBehaviour
{
    public List<Image> images;
    public List<Sprite> sprites;
    public Transform parent;
    private readonly List<string> spawners = new() { 
        "Spawner Kitchen",
        "Spawner Kitchen (1)",
        "Spawner Kitchen (2)",
        "Spawner Kitchen (3)",
        "Spawner TV Room",
        "Spawner Bedroom",
        "Spawner Bedroom (1)",
        "Spawner Bathroom"
    };
    private readonly List<Sprite> newSprites = new();
    private readonly List<string> spawnedItems = new();
    //private readonly List<string> spritesInIcons = new();
    public void Start()
    {
        GameObject go = GameObject.Find("ItemDescription");
        GlobalDictionary globalDictionary = go.GetComponent<GlobalDictionary>();
        Dictionary<string, int> itemWithValue = globalDictionary.getDictionary();

        foreach (string spawner in spawners)
        {
            GameObject go2 = GameObject.Find(spawner);
            SpawnObject spawnObject = go2.GetComponent<SpawnObject>();
            List<string> currentItems = spawnObject.getList();
            for (int i = 0; i < currentItems.Count; i++)
            {
                spawnedItems.Add(currentItems[i]);
            }
        }
        for (int i = 0; i < sprites.Count; i++)
        {
            if (spawnedItems.Contains(sprites[i].name))
                newSprites.Add(sprites[i]);
        }

        /*for (int i = 0; i < newSprites.Count; i++)
            Debug.Log(newSprites[i]);*/
        AssignSprites(Shuffle(newSprites), images);
    }

    void AssignSprites(IList<Sprite> sprites, IList<Image> images)
    {
        for (int i = 0; i < images.Count && i < sprites.Count; ++i)
        {
            images[i].sprite = sprites[i];
            parent = images[i].gameObject.transform.parent;
            parent.GetComponent<Image>().color = Color.red;
            //images[i].GetComponent<Image>().color = Color.red;
        }
    }

    private static IList<T> Shuffle<T>(IList<T> list)
    {
        RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
        IList<T> result = new List<T>(list);
        int n = result.Count;
        while (n > 1)
        {
            byte[] box = new byte[1];
            do provider.GetBytes(box);
            while (!(box[0] < n * (Byte.MaxValue / n)));
            int k = (box[0] % n);
            n--;
            T value = result[k];
            result[k] = result[n];
            result[n] = value;
        }
        return result;
    }
    /*public void AddItem(ItemInfo newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        icon.enabled = true;
    }*/
}
