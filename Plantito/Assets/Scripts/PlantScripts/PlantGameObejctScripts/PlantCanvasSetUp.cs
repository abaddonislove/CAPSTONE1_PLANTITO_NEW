using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantCanvasSetUp : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Canvas>().worldCamera = Camera.main;
    }
}
