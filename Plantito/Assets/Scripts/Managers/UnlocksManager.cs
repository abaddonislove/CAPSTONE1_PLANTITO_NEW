using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct PlantKnowledgeNode
{
    public string Name;
    public Item PlantKnowledgeItem;
    public Item[] PrerequisiteKnowledgeItem;
    public int PlantKnowledgePoints;
}

public class UnlocksManager : Singleton<UnlocksManager>
{

    public List<PlantKnowledgeNode> PlantKnowledgeNodes = new List<PlantKnowledgeNode>();

    public void UnlockPlantKnowledge(PlantKnowledgeNode _PKN)
    {
        bool isUnlockable = true;

        foreach (Item prequisiteItem in _PKN.PrerequisiteKnowledgeItem)
        {
            if (!prequisiteItem.IsAccessible)
            {
                Debug.Log("Prerequite item '" + prequisiteItem.Name + "' is not unlocked yet!");
                isUnlockable = false;
            }
        }

        if (isUnlockable)
        {
            GameItemsManager.Instance.UnlockItem(_PKN.PlantKnowledgeItem);
        }
    }
}
