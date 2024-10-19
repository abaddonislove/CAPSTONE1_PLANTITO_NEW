using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreItemDisplay : MonoBehaviour
{
    private Item item;
    public Item ItemData { get { return item; } set { item = value; } }

    [SerializeField]
    private Image itemImage;

    void Start()
    {
        InitializeValues();
    }

    void InitializeValues()
    {
        if (item is Plant plant)
        {
            itemImage.sprite = plant.PlantSprite[0];
        }
        
    }
}
