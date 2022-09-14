using UnityEngine;

public class Movement : MonoBehaviour
{
    public void Move (GameObject gameObject, float realSpeed)
    {
        gameObject.transform.Translate(0, 0, (float) 0.02 * realSpeed);
    }
    
    public void MoveSide(GameObject gameObject, float realSpeed)
    {
        gameObject.transform.Translate((float) 0.02 * realSpeed, 0, 0);
    }
}
