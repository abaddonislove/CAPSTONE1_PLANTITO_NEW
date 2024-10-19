using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayManager : Singleton<DayManager>
{
    public int DayCount;
    
    public void MoveToNextDay()
    {
        DayCount++;
        PlantManager.Instance.GrowPlants();
    }
}
