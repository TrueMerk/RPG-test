using UnityEngine;

public class WomenAnimationController : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private Quest _quest;
    private bool _questComplite;
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _quest.QuestComplete += QuestComplete;
    }

    private void QuestComplete()
    {
        _questComplite = true;
    }
    private void Update()
    {
       
        _animator.SetBool("isDialogueStarted",GetComponent<InstantiateDialogue>().isDialogueStarted);
        _animator.SetBool("isDialogueEnded",GetComponent<InstantiateDialogue>()._dialogueEnded);
        _animator.SetBool("isQuestComplite",GetComponent<WomenAnimationController>()._questComplite);
    }
}
