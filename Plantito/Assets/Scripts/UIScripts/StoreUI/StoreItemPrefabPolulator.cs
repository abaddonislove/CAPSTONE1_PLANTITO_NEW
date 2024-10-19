using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreItemPrefabPolulator : MonoBehaviour
{
    [SerializeField]
    private GameObject storeItemPrefab;
    [SerializeField]
    private Transform storeItemGrid;

    private void OnEnable()
    {
        GameItemsManager.Instance.UpdatedItems += PopulateStoreItemGrid;
    }

    private void OnDisable()
    {
        GameItemsManager.Instance.UpdatedItems -= PopulateStoreItemGrid;
    }

    private void Start()
    {
        Debug.Log(this.gameObject.name);
    }

    private void ResetGrid()
    {
        int storeItemSize = storeItemGrid.childCount;
        for (int i = 0; i < storeItemSize; i++)
        {
            Destroy(storeItemGrid.GetChild(i).transform.gameObject);
        }
    }

    public void PopulateStoreItemGrid()
    {
        ResetGrid();

        Debug.Log("AccessItemSize: " + GameItemsManager.Instance.AccessibleItems.Count);
        
        foreach(Item item in GameItemsManager.Instance.AccessibleItems)
        {
            GameObject newStoreItem = Instantiate(storeItemPrefab, storeItemGrid);
            newStoreItem.GetComponent<StoreItemDisplay>().ItemData = item;
        }
    }
}
