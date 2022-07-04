using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController2 : MonoBehaviour
{
    public Button newGameButton;
    public Button highScoresButton;
    public Button instructionsButton;
    public Button quitButton;
    public Button closeHsButton;

    private UIDocument mainUIDocument;
    private VisualElement menuInstructions;
    private VisualElement mainMenuBackground;
    private VisualElement hsPanel;



    private void Awake()
    {
        mainUIDocument = GetComponent<UIDocument>();
    }

    private void OnEnable()
    {
        var root = mainUIDocument.rootVisualElement;

        mainMenuBackground = root.Q("Background");
        menuInstructions = root.Q("Instructions");
        hsPanel = root.Q("HighScoresSM");


        newGameButton = root.Q<Button>("newGame-button");
        newGameButton.clicked += StartButtonPressed; // En C# el operador += específica el método que se debe llmar en respuesta a un evento


        highScoresButton = root.Q<Button>("highScores-button");
        highScoresButton.clicked += openHsPanel;


        instructionsButton = root.Q<Button>("instructions-button");
        instructionsButton.clicked += openInstructionsPanel;


        quitButton = root.Q<Button>("quit-button");
        quitButton.clicked += quitButtonPressed;

        closeHsButton = hsPanel.Q<Button>("close-button");
        closeHsButton.clicked += closeHsPanel;

        Button closeInstructionsButton = menuInstructions.Q<Button>("close-instructions");
        closeInstructionsButton.clicked += closeInstructionsPanel;



        


    }

    void openInstructionsPanel()
    {

        // Debug.Log(menuInstructions);
        //Debug.Log(mainMenuBackground);
        menuInstructions.style.display = DisplayStyle.Flex;
        mainMenuBackground.style.display = DisplayStyle.None;

    }
    void closeInstructionsPanel()
    {
        menuInstructions.style.display = DisplayStyle.None;
        mainMenuBackground.style.display = DisplayStyle.Flex;

    }

    void openHsPanel()
    {
        hsPanel.style.display = DisplayStyle.Flex;
        mainMenuBackground.style.display = DisplayStyle.None;

    }
    void closeHsPanel()
    {
        hsPanel.style.display = DisplayStyle.None;
        mainMenuBackground.style.display = DisplayStyle.Flex;

    }

    void StartButtonPressed()
    {
        SceneManager.LoadScene("ImageTracking");
 
    }

    void instructButtonPressed()
    {
        Debug.Log("INSTRUCTION BUTTON PRESSED");
    }
    void quitButtonPressed()
    {
        Application.Quit();
    }
}
