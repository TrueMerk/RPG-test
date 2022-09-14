using UnityEngine;

public class EnemyAudioController : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    public TakeDamage _takeDamage;
    private void Start()
    {
        _takeDamage.GetHit += HitAudio;
    }

    private void HitAudio()
    {
        _audio.enabled = false;
        _audio.enabled = true;
    }
}
