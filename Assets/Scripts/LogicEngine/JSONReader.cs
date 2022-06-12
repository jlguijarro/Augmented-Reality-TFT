using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{
    [SerializeField]
    public TextAsset textJson;
    public static Quizzes quizzes_processed;

    private void Start()
    {
        quizzes_processed = new Quizzes();
        quizzes_processed = JsonUtility.FromJson<Quizzes>(textJson.text);
        foreach (Quiz quiz in quizzes_processed.getRealQuizzes())
        {
            Debug.Log(quiz);

        }
        Debug.Log("Quizzes processed =" + quizzes_processed.quizzes);
        // Debug.Log(quizzes);
    }

    [System.Serializable]
    public class Quizzes
    {
        public Quiz[] quizzes;
        public Quiz[] getRealQuizzes()
        {

            return quizzes;
        }
    }

    public static Quiz[] getQuizzes()
    {
        return quizzes_processed.getRealQuizzes();
    }
}
