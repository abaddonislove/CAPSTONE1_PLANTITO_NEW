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
    public Transform PlantContainer;
    [SerializeField]
    private PlantObject plantPrefab;
    [SerializeField]
    private Plant[] plantScriptableObject;


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
        PlantObject newPlantObject = Instantiate(plantPrefab, PlantContainer);
        newPlantObject.Initialize(_plant);
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPlantObject.transform.position = new Vector3(MousePos.x, MousePos.y, this.transform.position.y);
        newPlantObject.GetComponent<PlantObjectAction>().IsDragSpawn = true;
        _plant.isStored = false;
        MoveToBackOfList(_plant);
    }

    private void MoveToBackOfList(PlantObjectData _plant)
    {
        PlantObjectData plantToBeMoved = _plant;
        PlantsOwned.Remove(_plant);
        PlantsOwned.Add(plantToBeMoved);
    }
}
