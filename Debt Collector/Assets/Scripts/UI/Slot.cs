using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Security.Cryptography;

public class Slot : MonoBehaviour
{
    //public Image icon;
    //ItemInfo item;
    public List<Image> Images;
    public List<Sprite> Sprites;
    public SpawnObject spawnObject;
    public List<string> spawnedItemsWithNoDuplicates;
    private void Start()
    {
        AssignSprites(Shuffle(Sprites), Images);
        /*for (int i = 0; i < spawnObject.spawnedItemsWithNoDuplicates.Count; i++)
            if (spawnObject.spawnedItemsWithNoDuplicates[i] != null)
            {
                try
                {
                    Debug.Log(spawnObject.spawnedItemsWithNoDuplicates);
                }
                catch (NullReferenceException ex)
                { }
            }*/
    }
    void AssignSprites(IList<Sprite> sprites, IList<Image> images)
    {
        for (int i = 0; i < images.Count && i < sprites.Count; ++i)
        {
            images[i].sprite = sprites[i];
            //Debug.Log(sprites[i].name); //WYPISYWANIE SAMEJ NAZWY PRZYPISANEGO SPRITE 
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
