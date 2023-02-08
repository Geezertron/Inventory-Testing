using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/InventoryList")]
public class InventoryList : ScriptableObject
{
        public List<ItemSO> inventoryItems = new List<ItemSO>();

}
