using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;

public class ItemDataComponentDisplay : MonoBehaviour
{
    private PlantObjectData item;
    public PlantObjectData ItemData { get { return item; } set { item = value; } }

    [SerializeField]
    private Image objectImage;
    [SerializeField]
    private TextMeshProUGUI commonName;
    [SerializeField]
    private TextMeshProUGUI scientificName;
    [SerializeField]
    private TextMeshProUGUI description;
    [SerializeField]
    private TextMeshProUGUI plantValue;

    // Start is called before the first frame update
    void Start()
    {
        InitializeValues();
    }
    
    void InitializeValues()
    {
        objectImage.sprite = item.plant.PlantSprite[0];
        commonName.text = item.plant.Name;
        description.text = item.plant.Description;
        plantValue.text = item.plant.MoneyValue[0].ToString();
    }
}
