using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataComponentAction : MonoBehaviour
{
    public void SellItem()
    {
        GameManager.Instance.Money += this.GetComponent<ItemDataComponentDisplay>().ItemData.plant.MoneyValue[(int)this.GetComponent<ItemDataComponentDisplay>().ItemData.currentStage];
        bool removed = PlantManager.Instance.PlantsOwned.Remove(this.GetComponent<ItemDataComponentDisplay>().ItemData);
        Debug.Log(removed);
        InventoryUIManager.Instance.GenerateInventoryUI();
        Destroy(this.gameObject);
        GameManager.Instance.PlantKnowledgePoints += 0.34f;
    }

    public void PlaceItem()
    {
        PlantManager.Instance.SpawnPlantObject(this.GetComponent<ItemDataComponentDisplay>().ItemData);
        InventoryUIManager.Instance.GenerateInventoryUI();
        Destroy(this.gameObject);
    }
}
