using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Quiz : ScriptableObject
{
    [SerializeField] public string markerId;
    [SerializeField] public string question;
    [SerializeField] public string[] answers;
    [SerializeField] public string correctAnswer;

    public string Question { get { return question; } }
    public string MarkerId { get { return markerId; } }

    public string[] Answers { get { return answers; } }
    public string CorrectAnswer { get { return correctAnswer; } }
}
