using System;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    [SerializeField] private EnemySpot _enemySpot;
    [SerializeField] private Text _text;
    public event Action QuestComplete;
    private void Start()
    {
        _enemySpot.SpotIsClearEvent += ShowQuest;
    }
    
    private void ShowQuest()
    {
        QuestComplete?.Invoke();
        _text.text = "Задание выполнено";
    }
}
