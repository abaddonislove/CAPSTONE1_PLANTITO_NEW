using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoreItemDataComponentDisplay : MonoBehaviour
{
    private Item item;
    public Item ItemData { get { return item; } set { item = value; } }

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
        if (item.GetType() == typeof(Plant))
        {
            Plant plantObject = item as Plant;

            objectImage.sprite = plantObject.PlantSprite[0];
            commonName.text = plantObject.name;

            plantValue.text = plantObject.MoneyValue[0].ToString();
        }

    }
}
