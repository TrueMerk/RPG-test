using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemySpot : MonoBehaviour
{
    [FormerlySerializedAs("Enemys")] [SerializeField] public List<Enemy> EnemyList = new List<Enemy>();
    public event Action SpotIsClearEvent;
    private void Start()
    {
        foreach (var vEnemy in EnemyList)
        {
            vEnemy.DieEvent += SpotIsClear;
        }
    }
    
    private void SpotIsClear()
    {
        
        EnemyList.Remove(EnemyList[0]);
        if (EnemyList.Count < 1)
        {
            Debug.Log("Задание выполнено");
            SpotIsClearEvent?.Invoke();
        }
    }
}