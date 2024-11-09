using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemAction : MonoBehaviour
{
    public bool IsDragSpawn;
    private void Update()
    {
        if (IsDragSpawn)
        {
            this.transform.GetComponent<InventoryItemDrag>().DragObject();

            if (Input.GetMouseButtonUp(0))
            {
                IsDragSpawn = false;
                ReturnPlantToGrid();
            }
        }
    }

    public void GeneratePlantDisplayButtonPressed()
    {
        PlantObjectData plantObjectData = this.GetComponent<InventoryItemDisplay>().PlantObjectData;

        if (plantObjectData != null)
        {
            InventoryUIManager.Instance.GeneratePlantDisplay(plantObjectData);
        }
    }

    public void ReturnPlantToGrid()
    {
        this.GetComponent<InventoryItemDisplay>().PlantObjectData.isStored = true;
        this.transform.parent = InventoryUIManager.Instance.InventoryGridTransform;
    }
}
