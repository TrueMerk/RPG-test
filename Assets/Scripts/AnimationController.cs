using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

   
    private void Update()
    {
        _animator.SetInteger("speed",GetComponent<PlayerMover>().speed);
        _animator.SetInteger("lrmove",GetComponent<PlayerMover>().lrmove);
        _animator.SetBool("isAttac",GetComponent<PlayerMover>().isAttac);
        
    }
}
