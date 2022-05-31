using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class ItemInfo : ScriptableObject
{
    new public string name = "Name";
    public Sprite icon = null;
}
