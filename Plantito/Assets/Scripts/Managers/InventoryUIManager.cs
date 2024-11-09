using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InventoryUIManager : Singleton<InventoryUIManager>
{
    [SerializeField]
    public Transform InventoryGridTransform;
    [SerializeField]
    public GameObject InventoryPanelObject;
    [SerializeField] 
    private Transform horizontalGridTransform;
    [SerializeField]
    private GameObject inventoryItemPrefab;
    [SerializeField]
    private GameObject itemDataComponentPrefab;
    [SerializeField]
    private BoxCollider2D inventoryArea;

    void Start()
    {
        GenerateInventoryUI();
    }

    public void GeneratePlantDisplay(PlantObjectData _item)
    {
        if (horizontalGridTransform.childCount > 1)
        {
            Destroy(horizontalGridTransform.GetChild(1).gameObject);
        }

        GameObject newItemDataComponent = Instantiate(itemDataComponentPrefab, horizontalGridTransform);
        newItemDataComponent.GetComponent<ItemDataComponentDisplay>().ItemData = _item;
    }

    public void GenerateInventoryUI()
    {
        for (int i = 0; i < InventoryGridTransform.childCount; i++)
        {
            Destroy(InventoryGridTransform.GetChild(i).gameObject);
        }

        List<PlantObjectData> plantsOwned = PlantManager.Instance.PlantsOwned;
        Debug.Log(plantsOwned.Count);

        foreach (PlantObjectData plant in plantsOwned)
        {
            if (plant.isStored)
            { 
                GameObject newInventoryItem = Instantiate(inventoryItemPrefab, InventoryGridTransform);
                newInventoryItem.GetComponent<InventoryItemDisplay>().PlantObjectData = plant;
            }
        }
    }

    public void GenerateLastInventoryItem()
    {
        GameObject newInventoryItem = Instantiate(inventoryItemPrefab, inventoryArea.transform);
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newInventoryItem.transform.position = new Vector3(MousePos.x, MousePos.y, 0.0f);
        newInventoryItem.GetComponent<InventoryItemDisplay>().PlantObjectData = PlantManager.Instance.PlantsOwned.Last<PlantObjectData>();
        newInventoryItem.GetComponent<InventoryItemAction>().IsDragSpawn = true;
    }

    public bool CheckIsOutside()
    {
        return !inventoryArea.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
}
