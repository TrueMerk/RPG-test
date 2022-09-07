using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float rotateSpeed = 10000;
    private Vector3 offset;
     
    private void Start()
    {   var transformPosition = transform.position;
        offset = target.transform.position - transformPosition;
        
    }
     
    private void LateUpdate() {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.transform.Rotate(0, horizontal, 0);
 
        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position -(rotation * offset);
         
        transform.LookAt(target.transform);
    }
}
