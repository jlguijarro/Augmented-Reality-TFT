using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class UIQuiz1 : MonoBehaviour
{

    //[SerializeField]
    private Quiz quiz1;
    private Dictionary<string, Quiz> quizList;


    private UIDocument quiz1_UIDocument;
    private VisualElement quiz1_panel;
    private Label quiz1_question;
    private Button quiz1_answer1;
    private Button quiz1_answer2;
    private Button quiz1_answer3;
    private Button quiz1_answer4;

    private string[] answers;
    // Start is called before the first frame update

    public void Awake()
    {
        // LogicEngine.LoadScriptableOBjects();
        quiz1_UIDocument = GetComponent<UIDocument>();
        quizList = LogicEngine.getSODictionary();
        quiz1 = quizList["Green"];
        
    }

    public void OnEnable()
    {
        var root = quiz1_UIDocument.rootVisualElement;
        quiz1_panel = root.Q("quiz-panel");

        quiz1_question = quiz1_panel.Q<Label>("quiz-question");
        //quiz1_question.text = quiz1.Question;

        //answers = quiz1.Answers;
        quiz1_answer1 = quiz1_panel.Q<Button>("quiz-answer1");
        //quiz1_answer1.clicked += activateClick;

        quiz1_answer2 = quiz1_panel.Q<Button>("quiz-answer2");
        quiz1_answer3 = quiz1_panel.Q<Button>("quiz-answer3");
        quiz1_answer4 = quiz1_panel.Q<Button>("quiz-answer4");
        //quiz1_answer1.text = answers[0];
        //quiz1_answer2.text = answers[1];
        //quiz1_answer3.text = answers[2];
        //quiz1_answer4.text = answers[3];









    }

    public void activateClick()
    {
        LogicEngine.LoadScriptableOBjects();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
