using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlantType
{
    Nonbearing,
    Bearing
}

[CreateAssetMenu(fileName = "New Plant", menuName = "Plant/Plant")]
public class Plant : Item
{
    public Sprite[] PlantSprite;
    public string ScientificName;
    [TextArea]
    public string Description;
    public int[] MoneyValue;
    public int[] PlantDayStageMarks;
    public PlantType Type;
}
