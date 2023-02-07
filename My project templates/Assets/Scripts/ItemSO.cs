using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ItemSO")]
public class ItemSO : ScriptableObject
{
    public string itemName = "new Item";
    public Sprite itemIcon = null;
    
    public int value;
}
