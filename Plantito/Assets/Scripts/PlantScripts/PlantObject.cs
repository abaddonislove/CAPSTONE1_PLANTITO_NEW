using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlantObject : MonoBehaviour
{
    public PlantObjectData PlantObjectData;
    private SpriteRenderer plantSprite;

    private void Awake()
    {
        plantSprite = this.GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
    }

    public void Initialize(PlantObjectData _plantObjectData)
    {
        PlantObjectData = _plantObjectData;
        plantSprite.sprite = PlantObjectData.plant.PlantSprite[(int)PlantObjectData.currentStage];
    }

}
