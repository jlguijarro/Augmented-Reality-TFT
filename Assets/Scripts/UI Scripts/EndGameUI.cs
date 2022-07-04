
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class EndGameUI : MonoBehaviour
{

    private Button sendScore;
    private Button closeHsPanel;
    private TextField inputName;
    private UIDocument endGameUI;
    private VisualElement endGamePanel;
    private VisualElement endHsPanel;

    private void Awake()
    {
        endGameUI = GetComponent<UIDocument>();
    }

    private void OnEnable()
    {
        var root = endGameUI.rootVisualElement;

        endGamePanel = root.Q("endgame-panel");
        endHsPanel = root.Q("HighScoresEnd-Panel");

        inputName = endGamePanel.Q<TextField>("input-name");
        sendScore = endGamePanel.Q<Button>("send-score");
        closeHsPanel = endHsPanel.Q<Button>("close-button");

        sendScore.clicked += ScoreIsSent;
        closeHsPanel.clicked += endGame;

    }

    private void ScoreIsSent()
    {
        endHsPanel.style.display = DisplayStyle.Flex;
        endGamePanel.style.display = DisplayStyle.None;
    }

    private void endGame()
    {
        Debug.Log("BUTTON WAS CLICKED");
        SceneManager.LoadScene("ReStartGameScene");
    }

    private void handleInput()
    {
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }
}
