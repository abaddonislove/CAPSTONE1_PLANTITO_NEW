using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemDrag : MonoBehaviour
{
    private bool isDragging;

    public void DragObject()
    {
        //this.transform.SetParent(PlantManager.Instance.PlantContainer);
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(MousePos.x, MousePos.y, 0.0f);
        this.transform.parent = InventoryUIManager.Instance.InventoryPanelObject.transform;

        if (InventoryUIManager.Instance.CheckIsOutside())
        {
            PlantManager.Instance.SpawnPlantObject(this.GetComponent<InventoryItemDisplay>().PlantObjectData);
            //InventoryUIManager.Instance.GenerateInventoryUI();
            Destroy(this.gameObject);
        }
    }

    public void DropObject()
    {
        if (!InventoryUIManager.Instance.CheckIsOutside())
        {
            this.GetComponent<InventoryItemAction>().ReturnPlantToGrid();
        }
    }
}
