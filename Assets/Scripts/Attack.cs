using UnityEngine;

public class Attack : MonoBehaviour
{
    public bool isAttack;
    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            isAttack = true;
        }
        else
        {
            isAttack = false;
        }
    }
}
