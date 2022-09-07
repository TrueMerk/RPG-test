using UnityEngine;
using UnityEngine.UI;

public class InstantiateDialogue : MonoBehaviour
{
    [SerializeField] private GameObject _window;


    [SerializeField] private Text _text;
    [SerializeField] private Text _firstAnswer;
    [SerializeField] private Text _secondAnswer;
    [SerializeField] private Text _thirdAnswer;
    [SerializeField] private Button _firstButton;
    [SerializeField] private Button _secondButton;
    [SerializeField] private Button _thirdButton;
    [SerializeField] private GameObject _textKillBandits;
    [SerializeField] private GameObject _cam1;
    [SerializeField] private GameObject _cam2;
    [SerializeField] private Quest _quest;
    [SerializeField] private TextAsset _dialogue2;
   
    
    [SerializeField] private GameObject _player;
    [SerializeField] private TextAsset _ta;

    [SerializeField]
    public int currentNode = 0;
    public int butClicked;
    private bool _textSet = false;
    private Node[] _nd;
    private Dialogue _dialogue;
    
    public bool _dialogueEnded = false;

    public bool isDialogueStarted;

    private void Start()
    {
        _secondButton.enabled = false;
        _thirdButton.enabled = false;
        _window.SetActive(false);
        _dialogue = Dialogue.Load(_ta);
        _nd = _dialogue.nodes;

        _quest.QuestComplete += QuestComplete;
        _text.text = _nd[currentNode].Npctext;
        _firstAnswer.text = _nd[currentNode].answers[currentNode].text;

        _firstButton.onClick.AddListener(But1);
        _secondButton.onClick.AddListener(But2);
        _thirdButton.onClick.AddListener(But3);

        AnswerClicked(14); 
    }

    private void Update()
    {
        if (Vector3.Distance(_player.transform.position, transform.position) < 2f && _dialogueEnded == false)
        {
            _window.SetActive(true);
            _textKillBandits.SetActive(true);
            isDialogueStarted = true;
            _cam1.SetActive(false);
            _cam2.SetActive(true);
        }
        else
        {
            _window.SetActive(false);
            isDialogueStarted = false;
            _cam2.SetActive(false);
            _cam1.SetActive(true);
        }
            
    }

    private void But1()
    {
        butClicked = 0;
        AnswerClicked(0);
    }
    private void But2()
    {
        butClicked = 1;
        AnswerClicked(1);
    }
    private void But3()
    {
        butClicked = 2;
        AnswerClicked(2);
    }


    private void AnswerClicked(int numberOfButton)
    {

        if (numberOfButton == 14)
            currentNode = 0;
        else
        {
            if (_dialogue.nodes[currentNode].answers[numberOfButton].end == "true")
            {
                _dialogueEnded = true;
            }
                
            currentNode = _dialogue.nodes[currentNode].answers[numberOfButton].nextNode;
        }
        
        _text.text = _dialogue.nodes[currentNode].Npctext;

        _firstAnswer.text = _dialogue.nodes[currentNode].answers[0].text;
        if (_dialogue.nodes[currentNode].answers.Length == 2)
        {
            _secondButton.enabled = true;
            _secondAnswer.text = _dialogue.nodes[currentNode].answers[1].text;
        }
        else {
            _secondButton.enabled = false;
            _secondAnswer.text = "";
        }

        if (_dialogue.nodes[currentNode].answers.Length == 3)
        {
            _thirdButton.enabled = true;
            _thirdAnswer.text = _dialogue.nodes[currentNode].answers[2].text;
        }
        else {
            _thirdButton.enabled = false;
            _thirdAnswer.text = "";
        }
    }

    private void QuestComplete()
    {
        _dialogueEnded = false;
        _dialogue = Dialogue.Load(_dialogue2);
        _nd = _dialogue.nodes;
        _text.text = _nd[currentNode].Npctext;
        _firstAnswer.text = _nd[currentNode].answers[currentNode].text;

        _firstButton.onClick.AddListener(But1);
        _secondButton.onClick.AddListener(But2);
        _thirdButton.onClick.AddListener(But3);

        AnswerClicked(14);  
    }
}
