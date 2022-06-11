using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LogicEngine
{
    public static List<Quiz> SOList = new List<Quiz>();
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
            SOList.Add(quiz);
        }
    }

    public static List<Quiz> getSOList()
    {
        return SOList;
    }

    public static string checkDictionary(string keyName)
    {
        return controlQuiz[keyName];
    }
}
