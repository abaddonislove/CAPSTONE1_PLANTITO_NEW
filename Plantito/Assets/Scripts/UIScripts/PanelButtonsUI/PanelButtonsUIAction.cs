using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelButtonsUIAction : MonoBehaviour
{
    [SerializeField]
    private GameObject inventoryPanel;
    [SerializeField]    
    private GameObject storePanel;

    public void ToggleInventoryPanel()
    {
        if (inventoryPanel.activeSelf)
        {
            inventoryPanel.SetActive(false);
            return;
        }

        if (storePanel.activeSelf)
        {
            storePanel.SetActive(false);
        }
        inventoryPanel.SetActive(true);
    }

    public void ToggleStorePanel()
    {
        if (storePanel.activeSelf)
        {
            storePanel.SetActive(false);
            return;
        }

        if (inventoryPanel.activeSelf)
        {
            inventoryPanel.SetActive(false);
        }
        storePanel.SetActive(true);
    }
}

