using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class StoreItemDataComponentAction : MonoBehaviour
{
    public void PurchaseItem()
    {
        Item item = this.GetComponent<StoreItemDataComponentDisplay>().ItemData;
        Plant _plant = null;

        if (item is Plant)
        {
            _plant = (Plant)item;
        }

        if (GameManager.Instance.Money > 2)//item.Price)
        {
            PlantManager.Instance.GeneratePlantObjectData(_plant);
            GameManager.Instance.Money -= 2;
        }
    }
}
