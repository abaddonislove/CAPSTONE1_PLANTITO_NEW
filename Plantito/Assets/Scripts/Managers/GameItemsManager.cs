using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Plant,
    Device,
    Consumable
}

[Serializable]
public struct CompositeKey
{
    public string id;
    public ItemType type;

    public CompositeKey(string id, ItemType type)
    {
        this.id = id;
        this.type = type;
    }

    public override bool Equals(object obj)
    {
        if (obj is CompositeKey)
        {
            CompositeKey other = (CompositeKey)obj;
            return this.id == other.id && this.type == other.type;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return id.GetHashCode() ^ type.GetHashCode();
    }
}

public class GameItemsManager : Singleton<GameItemsManager>
{
    public delegate void UpdateItemsEvent();
    public event UpdateItemsEvent UpdatedItems;

    public List<Item> AccessibleItems = new List<Item>();
    [SerializeField]
    private List<CompositeKey> keyValuePairs = new List<CompositeKey>();
    [SerializeField]
    public List<Item> items = new List<Item>();

    public Dictionary<CompositeKey, Item> gameItemDictionary = new Dictionary<CompositeKey, Item>();

    private void Awake()
    {
        for (int i = 0; i < keyValuePairs.Count; i++)
        {
            if (!gameItemDictionary.ContainsKey(keyValuePairs[0]))
            {
                gameItemDictionary.Add(keyValuePairs[0], items[0]);
            }
            else
            {
                Debug.LogWarning("Duplicate key: " + keyValuePairs[0].id + " int: " + i);  
            }

            Debug.Log("int: " + i);
        }

    }

    private void Start()
    {
        UpdateAccessibleItems();
        UpdatedItems.Invoke();
    }

    public List<Item> GetAccessibleItems()
    {
        List<Item> accessibleItems = new List<Item>();

        foreach(Item item in items)
        {
            if (item.IsAccessible)
            {
                accessibleItems.Add(item);
            }
        }

        return accessibleItems;
    }

    public void UpdateAccessibleItems()
    {
        AccessibleItems = GetAccessibleItems();
    }

    public void UnlockItem(Item item)
    {
        if (!item.IsAccessible)
        {
            item.IsAccessible = true;
        }

        UpdateAccessibleItems();
        this.GetComponent<StoreItemPrefabPolulator>().PopulateStoreItemGrid();
    }
}
