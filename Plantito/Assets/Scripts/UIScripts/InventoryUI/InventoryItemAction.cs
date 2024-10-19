using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
           
    }

    public void GeneratePlantDisplayButtonPressed()
    {
        PlantObjectData plantObjectData = this.GetComponent<InventoryItemDisplay>().PlantObjectData;

        if (plantObjectData != null)
        {
            InventoryUIManager.Instance.GeneratePlantDisplay(plantObjectData);
        }
    }
}
