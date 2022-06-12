using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz1
{
    [SerializeField]
    public string markerId;
    [SerializeField]
    public string question;
    [SerializeField]
    public string[] answers;
    [SerializeField]
    public int correctAnswer;

    public string MarkerId { get { return markerId; } }
    public string Question { get { return question; } }
    public string[] Answers { get { return answers; } }
    public int CorrectAnswer { get { return correctAnswer; } }
}
