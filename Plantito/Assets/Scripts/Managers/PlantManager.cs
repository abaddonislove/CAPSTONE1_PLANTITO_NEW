using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;

public class PlantManager : Singleton<PlantManager>
{
    [SerializeField]
    public List<PlantObjectData> PlantsOwned;
    [SerializeField]
    private PlantObject plantPrefab;
    [SerializeField]
    private Plant[] plantScriptableObject;
    [SerializeField]
    private Transform plantContainer;

    private void Awake()
    {
        PlantsOwned = new List<PlantObjectData>();
    }

    private void Start()
    {
    }

    public void GrowPlants()
    {
        if (PlantsOwned.Count == 0 || PlantsOwned == null)
        {
            return;
        }

        foreach (PlantObjectData plant in PlantsOwned)
        {
            plant.GrowPlant();
         
        }
    }

    public void AddToPlantsOwned(PlantObjectData _plant)
    {
        PlantsOwned.Add(_plant);
    }

    public void GeneratePlantObjectData(Plant _plant)
    {
        PlantObjectData newPlantObjectData = new PlantObjectData(_plant);
        AddToPlantsOwned(newPlantObjectData);
    }

    public void SpawnPlantObject(PlantObjectData _plant)
    {
        PlantObject newPlantObject = Instantiate(plantPrefab, plantContainer);
        newPlantObject.Initialize(_plant);
        newPlantObject.transform.position = Vector3.zero;
        _plant.isStored = false;
    }
}
