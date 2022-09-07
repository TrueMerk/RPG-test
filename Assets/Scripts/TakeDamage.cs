using System;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    private Animator _animator;
    public bool isDamaged;
    private float curr;
    private bool _dead;
    private AudioSource _audio;
    [SerializeField] private Collider _collider;
   [SerializeField] private float _health;
   
    void Start()
    {
        _animator = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();
        _dead = false;
    }
    
    void Update()
    {
        _animator.SetBool("isDamaged",GetComponent<TakeDamage>().isDamaged);
        _animator.SetBool("Dead",GetComponent<TakeDamage>()._dead);
        if (_health < 1)
        {
            _dead = true;
            _collider.enabled = false;
            if (curr<=Time.time)
            {
                gameObject.SetActive(false);
                curr = Single.MaxValue;
            }
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        isDamaged = true;
        _health--;
        _audio.enabled = false;
        _audio.enabled = true;
        curr = 5 + Time.time;
    }

    private void OnTriggerExit(Collider other)
    {
        isDamaged = false;
       
    }
}
