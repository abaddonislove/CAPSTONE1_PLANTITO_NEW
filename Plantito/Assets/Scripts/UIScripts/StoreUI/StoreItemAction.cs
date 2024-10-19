using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreItemAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void GeneratePlantDisplayButtonPressed()
    {
        Item plantObjectData = this.GetComponent<StoreItemDisplay>().ItemData;

        if (plantObjectData != null)
        {
            StoreUIManager.Instance.GenerateStoreDisplay(plantObjectData);
        }
    }
}
