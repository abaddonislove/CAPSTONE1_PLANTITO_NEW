using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemDisplay : MonoBehaviour
{
    private PlantObjectData plantObjectData;
    public PlantObjectData PlantObjectData { get { return plantObjectData; } set { plantObjectData = value; } }

    [SerializeField]
    private Image plantImage;

    void Start()
    {
        InitializeValues();
    }

    void InitializeValues()
    {
        plantImage.sprite = plantObjectData.plant.PlantSprite[0];
    }
}
