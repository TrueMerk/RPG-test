using UnityEngine;
using UnityEngine.UI;

public class TextShow : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void OnTriggerEnter(Collider other)
    {
        _text.enabled = true;
    }
}
