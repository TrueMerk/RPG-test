using UnityEngine;

public class Exit : MonoBehaviour
{
    
    private void Update()
    {
        if (Input.GetKey("escape"))  
        {
            Close();    
        }
    }

    public void Close()
    {
        Application.Quit(); 
    }
}
