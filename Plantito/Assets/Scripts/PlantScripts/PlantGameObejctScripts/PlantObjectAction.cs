using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantObjectAction : MonoBehaviour
{
    public bool IsDragSpawn;

    [SerializeField]
    private GameObject optionsUIl;

    private void Update()
    {
        if (IsDragSpawn)
        {
            this.transform.GetComponent<PlantObjectDrag>().DragObject();

            if (Input.GetMouseButtonUp(0))
            {
                IsDragSpawn = false;
            }
        }
    }

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
