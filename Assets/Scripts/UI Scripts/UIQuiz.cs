using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class UIQuiz : MonoBehaviour
{

    //[SerializeField]
    private Quiz quiz;


    private UIDocument quiz_UIDocument;
    private VisualElement quiz_panel;
    private Label quiz_question;
    private Button quiz_answer1;
    private Button quiz_answer2;
    private Button quiz_answer3;
    private Button quiz_answer4;
    private Button quiz_close;

    private string[] answers;
    private string correctAnswer;

    public void Awake()
    {
        quiz_UIDocument = GetComponent<UIDocument>(); 
    }

    public void OnEnable()
    {
        var root = quiz_UIDocument.rootVisualElement;
        quiz_panel = root.Q("quiz-panel");
        quiz_question = quiz_panel.Q<Label>("quiz-question");

        quiz_answer1 = quiz_panel.Q<Button>("quiz-answer1");
        quiz_answer2 = quiz_panel.Q<Button>("quiz-answer2");
        quiz_answer3 = quiz_panel.Q<Button>("quiz-answer3");
        quiz_answer4 = quiz_panel.Q<Button>("quiz-answer4");
        quiz_answer1.clicked += () =>
        {
            checkAnswer(0);
        };
        quiz_answer2.clicked += () =>
        {
            checkAnswer(1);
        };
        quiz_answer3.clicked += () =>
        {
            checkAnswer(2);
        };
        quiz_answer4.clicked += () =>
        {
            checkAnswer(3);
        };


        quiz_close = quiz_panel.Q<Button>("close-button");
        quiz_close.clicked += closeUIQuiz;






    }

    public void loadQuiz()
    {
        quiz = LogicEngine.loadQuizUI();
        fillQuiz();
    }
    private void fillQuiz()
    {
        quiz_question.text = quiz.Question;
        answers = quiz.Answers;
        quiz_answer1.text = answers[0];
        quiz_answer2.text = answers[1];
        quiz_answer3.text = answers[2];
        quiz_answer4.text = answers[3];
        correctAnswer = quiz.CorrectAnswer;
        showQuizUI();
    }
    private void showQuizUI()
    {
        quiz_panel.style.display = DisplayStyle.Flex;
    }
    private void hideQuizUI()
    {
        quiz_panel.style.display = DisplayStyle.None;
    }
    public void checkAnswer(int answerIndex)
    {
        if(answers[answerIndex] == correctAnswer)
        {
            Debug.Log(answers[answerIndex] + " & " + correctAnswer);
            LogicEngine.IsCorrect();
            closeUIQuiz();
        }
        else
        {
            closeUIQuiz(); // NEEDS UI WORK, STYLYNG, TRANSITION AND ANIMATION
        }
    }

    private void closeUIQuiz()
    {

        LogicEngine.deactivate();
        hideQuizUI();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
