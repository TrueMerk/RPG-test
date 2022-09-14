using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator _animator;
    private PlayerMover _playerMover;
    private Attack _attack;
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerMover = GetComponent<PlayerMover>();
        _attack = GetComponent<Attack>();

    }

   
    private void Update()
    {
        _animator.SetInteger("speed",_playerMover.speed);
        _animator.SetInteger("lrmove",_playerMover.sidemovement);
        _animator.SetBool("isAttac",_attack.isAttack);
        
    }
}
