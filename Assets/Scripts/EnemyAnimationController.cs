using UnityEngine;

public class EnemyAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public TakeDamage _takeDamage;
    private void Start()
    {
        _takeDamage.GetHit += HitAnimate;
    }
    
    private void HitAnimate()
    {
        _animator.SetBool("isDamaged",true);
        _animator.SetBool("Dead",true);
    }

}
