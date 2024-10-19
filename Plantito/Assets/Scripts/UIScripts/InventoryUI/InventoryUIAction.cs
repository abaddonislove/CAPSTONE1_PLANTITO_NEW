using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIAction : MonoBehaviour
{
    [SerializeField]
    private Transform Inventory;
    private void OnEnable()
    {
        InventoryUIManager.Instance.GenerateInventoryUI();
    }

    private void OnDisable()
    {
/*        for (int i = 0; i < Inventory.childCount; i++)
        {
            Destroy(Inventory.GetChild(i).gameObject);
        }*/
    }
}
