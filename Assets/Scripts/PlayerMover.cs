using UnityEngine;

public class PlayerMover : MonoBehaviour
{
   
    [SerializeField] private Transform _object;
    private int _realSpeed = 3;
    public int speed;
    public bool isAttac;
    public int lrmove;
    
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _object.transform.Translate(0, 0, (float) 0.02 * _realSpeed);
            speed = 1;
           
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _object.transform.Translate(0, 0, (float) 0.02 * -_realSpeed);
            speed = 2;
            
        }
        else
        {
            speed = 0;
            
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            _object.transform.Translate((float) 0.02 * _realSpeed, 0, 0);
            lrmove=1;
        }
        
        else if (Input.GetKey(KeyCode.A))
        {
            _object.transform.Translate((float) 0.02 * -_realSpeed, 0, 0);
            lrmove=2;
        }
        else
        {
            lrmove = 0;
        }
        
        if (Input.GetKey(KeyCode.F))
        {
             isAttac = true;
        }
        else
        {
             isAttac = false;
        }
    }
}
