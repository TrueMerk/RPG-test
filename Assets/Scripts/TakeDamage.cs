using System;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    [SerializeField] private Collider _collider;
    [SerializeField] private float _health;
    private float _time;
    private bool _dead;
    
  
    public event Action GetHit;
   
    private void Start()
    {
        _dead = false;
    }
    
    private void Update()
    {
        
        if (_health < 1)
        {
            _dead = true;
            _collider.enabled = false;
            if (_time<=Time.time)
            {
                gameObject.SetActive(false);
                _time = Single.MaxValue;
            }
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        _health--;
        GetHit?.Invoke();
        _time = 5 + Time.time;
    }
    
}
