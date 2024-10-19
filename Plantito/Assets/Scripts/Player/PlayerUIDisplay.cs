using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI moneyValue;
    [SerializeField]
    private TextMeshProUGUI dayValue;
    [SerializeField]
    private Image plantLevel;
    [SerializeField]
    private TextMeshProUGUI plantLevelNumber;

    void Update()
    {
        moneyValue.text = GameManager.Instance.Money.ToString();
        dayValue.text = GameManager.Instance.DaysPassed.ToString();
        plantLevel.fillAmount = GameManager.Instance.PlantKnowledge;
        plantLevelNumber.text = GameManager.Instance.PlantLevel.ToString();
    }
}
