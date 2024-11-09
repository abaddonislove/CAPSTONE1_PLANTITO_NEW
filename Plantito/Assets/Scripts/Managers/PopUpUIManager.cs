using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpUIManager : Singleton<PopUpUIManager>
{
    [SerializeField]
    private Transform verticalGridContainer;
    [SerializeField]
    private GameObject popUpPrefab;

    public void AddNewPopUp(string _objectName ,string _value)
    {
        GameObject newPopUp = Instantiate(popUpPrefab, verticalGridContainer);
        newPopUp.GetComponent<ActionInfoDisplay>().InitializeDisplay(_objectName, _value);
    }
}
