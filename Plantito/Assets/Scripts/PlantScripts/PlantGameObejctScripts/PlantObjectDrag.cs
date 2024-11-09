using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantObjectDrag : MonoBehaviour
{
    public void DragObject()
    {
        Vector3 MousePos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(MousePos.x, MousePos.y, this.transform.position.y);

        if (!InventoryUIManager.Instance.CheckIsOutside())
        {
            this.transform.GetComponent<PlantObjectAction>().StoreButtonPressed();
            InventoryUIManager.Instance.GenerateLastInventoryItem();
        }
    }

    public void StopDrag()
    {
        //Debug.Log("dropped");
        //if (this.transform.GetComponent<PlantObjectAction>().IsDragSpawn) { this.transform.GetComponent<PlantObjectAction>().IsDragSpawn = false; }
    }
}
