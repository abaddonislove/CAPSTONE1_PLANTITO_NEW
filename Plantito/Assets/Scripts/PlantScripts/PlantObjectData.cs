using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlantStage
{
    Seedling,
    Young,
    Adult
}

public class PlantObjectData
{
    public Plant plant;
    public int daysLived = 0;
    public PlantStage currentStage;
    public bool isStored = true;

    public PlantObjectData(Plant _plant)
    {
        plant = _plant;
        currentStage = PlantStage.Seedling;
    }

    public void GrowPlant()
    {
        if (!isStored)
        {
            daysLived++;
            UpdateCurrentStage();
        }
    }

    private void UpdateCurrentStage()
    {
        for(int i = plant.PlantDayStageMarks.Length; i > 0; i--)
        {
            if (daysLived >= plant.PlantDayStageMarks[i-1])
            {
                currentStage = (PlantStage)i;
                Debug.Log((PlantStage)i);
                return;
            }
        }
        return;
    }
}
