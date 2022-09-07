using System;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
   [SerializeField] private EnemySpot _enemySpot;
   [SerializeField] private Text _counterText;
   private float _counter;

   private void Start()
   {
      foreach (var vEnemy in _enemySpot.EnemyList)
      {
         vEnemy.DieEvent += Count;
      }
   }

   private void Update()
   {
      //Debug.Log(_counter);
   }

   private void Count()
   {
      _counter++;
      _counterText.text = _counter.ToString();
   }
}
