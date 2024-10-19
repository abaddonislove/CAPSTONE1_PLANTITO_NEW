using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StoreItems : MonoBehaviour
{
    public List<Item> Items;

    private void Start()
    {
        Items = GameItemsManager.Instance.GetAccessibleItems();
    }
}
