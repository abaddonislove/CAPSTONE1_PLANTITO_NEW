using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesNodeDisplay : MonoBehaviour
{
    private PlantKnowledgeNode plantKnowledgeNodeData;
    public PlantKnowledgeNode PlantKnowledgeNodeData { get { return plantKnowledgeNodeData; } set { plantKnowledgeNodeData = value; } }

    [SerializeField]
    private Image plantImage;
    [SerializeField]
    private int upgradeValue;
    [SerializeField]
    private int upgradeNodeIndex;

    // Start is called before the first frame update
    void Start()
    {
        InitializeValues();
    }

    void InitializeValues()
    {
        /*plantImage.sprite = plantObjectData.plant.PlantSprite[0];
        upgradeValue = */
    }
}
