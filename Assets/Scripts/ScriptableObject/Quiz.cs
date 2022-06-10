using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Quiz : ScriptableObject
{
    [SerializeField] public string question;
    [SerializeField] public string[] answers;
    [SerializeField] public int correctAnswer;

    public string Question { get { return question; } }
    public string[] Answers { get { return answers; } }
    public int CorrectAnswer { get { return correctAnswer; } }
}
