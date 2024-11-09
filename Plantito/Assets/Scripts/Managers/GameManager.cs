using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GameObject HeldPlant;
    public int Money = 0;
    public int DaysPassed = 0;
    public int PlantKnowledgePoints = 0;
    public float PlantKnowledge = 0;
    public float PlantLevel = 0;
    private bool isLevel1 = false;

    private void Update()
    {
        if (PlantKnowledgePoints >= 1)
        {
            PlantLevel++;
            PlantKnowledgePoints++;
            PlantKnowledge = 0;
        }

        if (PlantLevel >= 1 && !isLevel1)
        {
            GameItemsManager.Instance.UnlockItem(GameItemsManager.Instance.items[1]);
            isLevel1 = true;
        }
    }

    public void NextDay()
    {
        DaysPassed++;
        PlantManager.Instance.GrowPlants();
    }
}
