using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public static class LogicEngine
{
    public static Dictionary<string, Quiz> SODictionary = new Dictionary<string, Quiz>();
    public static Dictionary<string, string> controlQuiz = new Dictionary<string, string>();
    public static bool isActive;
    public static string activeQuiz;
    public static int currentScore;

    static LogicEngine()
    {
        currentScore = 0;
        LoadScriptableOBjects();
        controlQuiz.Add("Yellow", "Unsolved");
        controlQuiz.Add("Blue", "Unsolved");
        controlQuiz.Add("Red", "Unsolved");
        controlQuiz.Add("Green", "Unsolved");
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

    public static bool IsNotActive()
    {
        return !isActive;
    }
    public static void activate()
    {
        isActive = true;
    }

    public static void deactivate()
    {
        isActive = false;
        deactivateQuiz();
    }

    public static void setActiveQuiz(string toActivate)
    {
        activate();
        activeQuiz = toActivate;
    }

    public static void deactivateQuiz()
    {
        activeQuiz = "";
    }

    public static Quiz loadQuizUI()
    {
        return SODictionary[activeQuiz];
    }
    public static void IsCorrect()
    {
        controlQuiz[activeQuiz] = "Solved";
        Debug.Log(activeQuiz + " : " + controlQuiz[activeQuiz]);
        destroyTrackableInstances();
        ++currentScore;
        checkCurrentScore();

    }
    public static void destroyTrackableInstances()
    {
        var destroyList = GameObject.FindWithTag("ARSessionOrigin").GetComponent<ARTrackedImageManager>().trackables;
        foreach (ARTrackedImage toDestroy in destroyList)
        {
            GameObject.Destroy(toDestroy.transform.GetChild(0).gameObject);
        }
    }
    public static void checkCurrentScore()
    {
        Debug.Log(currentScore);
        if (currentScore >= 3)
        {
            endGameScene();
        }
    }

    public static int getCurrentScore()
    {
        return currentScore;
    }
    public static void endGameScene()
    {
        SceneManager.LoadScene("EndGameScene");
    }
}
