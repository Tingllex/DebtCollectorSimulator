using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Security.Cryptography;

public class Slot : MonoBehaviour
{
    //public Image icon;
    //ItemInfo item;
    public List<Image> Icons;
    public List<Sprite> Sprites;

    private void Start()
    {
        AssignSprites(Shuffle(Sprites), Icons);
    }
    void AssignSprites(IList<Sprite> sprites, IList<Image> images)
    {
        for (int i = 0; i < images.Count && i < sprites.Count; ++i)
            images[i].sprite = sprites[i];
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
