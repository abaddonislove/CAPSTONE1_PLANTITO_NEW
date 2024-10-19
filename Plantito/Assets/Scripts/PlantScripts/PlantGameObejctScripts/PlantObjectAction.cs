using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantObjectAction : MonoBehaviour
{
    [SerializeField]
    private GameObject optionsUIl;

    public void ToggleOptionsUI()
    {
        Debug.Log("clicked");

        if (optionsUIl.activeSelf)
        {
            optionsUIl.SetActive(false);
        }
        else
        {
            optionsUIl.SetActive(true);
        }
    }

    public void StoreButtonPressed()
    {
        this.GetComponent<PlantObject>().PlantObjectData.isStored = true;
        Destroy(this.gameObject);
    }
}
