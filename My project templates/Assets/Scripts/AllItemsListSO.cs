using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/allItemsList")]

public class AllItemsListSO : ScriptableObject
{
    public List<ItemSO> allItems = new List<ItemSO>();


    void Start()
    {
        
    }

    
}
