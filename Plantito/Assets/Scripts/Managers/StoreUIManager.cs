using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreUIManager : Singleton<StoreUIManager>
{
    [SerializeField]
    private Transform horizontalGridTransform;
    [SerializeField]
    private GameObject storeItemDataComponentPrefab;

    public void GenerateStoreDisplay(Item _itemData)
    {
        if (horizontalGridTransform.childCount > 1)
        {
            Destroy(horizontalGridTransform.GetChild(1).gameObject);
        }

        GameObject newItemDataComponent = Instantiate(storeItemDataComponentPrefab, horizontalGridTransform);
        newItemDataComponent.GetComponent<StoreItemDataComponentDisplay>().ItemData = _itemData;
    }
}
