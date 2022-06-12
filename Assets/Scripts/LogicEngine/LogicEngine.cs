using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LogicEngine
{
    public static Dictionary<string, Quiz> SODictionary = new Dictionary<string, Quiz>();
    public static Dictionary<string, string> controlQuiz = new Dictionary<string, string>();
    
    static LogicEngine()
    {
        LoadScriptableOBjects();
        controlQuiz.Add("YellowCube", "Unsolved");
        controlQuiz.Add("BlueCube", "Unsolved");
        controlQuiz.Add("RedCube", "Unsolved");
        controlQuiz.Add("GreenCube", "Solved");
    }


    public static void LoadScriptableOBjects()
    {
        foreach (Quiz quiz in Resources.LoadAll<Quiz>("SOInstances"))
        {
            SODictionary.Add(quiz.name, quiz);
            Debug.Log(SODictionary[quiz.name]);
        }
    }

    public static Dictionary<string, Quiz> getSODictionary()
    {
        return SODictionary;
    }

    public static string checkDictionary(string keyName)
    {
        return controlQuiz[keyName];
    }
}
