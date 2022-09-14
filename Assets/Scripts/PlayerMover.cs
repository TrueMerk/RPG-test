using System;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
   
    [SerializeField] private GameObject _object;
    private int _realSpeed = 3;
    private Movement mover;
    public int speed;
    public int sidemovement;

    private void Awake()
    {
         mover = _object.GetComponent<Movement>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            mover.Move(_object,_realSpeed);
            speed = 1;
           
        }
        else if (Input.GetKey(KeyCode.S))
        {
            mover.Move(_object,-_realSpeed);
            speed = 2;
            
        }
        else
        {
            speed = 0;
            
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            mover.MoveSide(_object,_realSpeed);
            sidemovement=1;
        }
        
        else if (Input.GetKey(KeyCode.A))
        {
            mover.MoveSide(_object,-_realSpeed);
            sidemovement=2;
        }
        else
        {
            sidemovement = 0;
        }
        
    }
}
