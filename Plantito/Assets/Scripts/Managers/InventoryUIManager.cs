using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIManager : Singleton<InventoryUIManager>
{
    [SerializeField]
    private Transform inventoryGridTransform;
    [SerializeField] 
    private Transform horizontalGridTransform;
    [SerializeField]
    private GameObject inventoryPanelObject;
    [SerializeField]
    private GameObject inventoryItemPrefab;
    [SerializeField]
    private GameObject itemDataComponentPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GenerateInventoryUI();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        for (int i = 0; i < inventoryGridTransform.childCount; i++)
        {
            Destroy(inventoryGridTransform.GetChild(i).gameObject);
        }

        List<PlantObjectData> plantsOwned = PlantManager.Instance.PlantsOwned;
        Debug.Log(plantsOwned.Count);

        foreach (PlantObjectData plant in plantsOwned)
        {
            if (plant.isStored)
            { 
                GameObject newInventoryItem = Instantiate(inventoryItemPrefab, inventoryGridTransform);
                newInventoryItem.GetComponent<InventoryItemDisplay>().PlantObjectData = plant;
            }
        }
    }
}
