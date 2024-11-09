using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class ActionInfoDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI objectName;
    [SerializeField]
    private TextMeshProUGUI objectValue;

    public void InitializeDisplay(string _objectName, string _value)
    {
        objectName.text = _objectName;
        objectValue.text = "x " + _value;
    }
}
