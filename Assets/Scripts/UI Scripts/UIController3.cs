using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController3 : MonoBehaviour
{
    private Button inGame_openSettingsButton;
    private Button inGame_closeSettingsButton;
    private Button inGame_openInstructionsButton;
    private Button inGame_closeInstructionsButton;


    private UIDocument inGame_mainUIDocument;
    private VisualElement inGame_menuSettings;
    private VisualElement inGame_Hud;
    private VisualElement inGame_Instructions;

    private TextElement HudScore;

    private void Awake()
    {
        inGame_mainUIDocument = GetComponent<UIDocument>();
    }

    private void Start()
    {
        inGame_Hud.style.display = DisplayStyle.Flex;
    }

    public void Update()
    {
        HudScore.text = retrieveScore();
    }

    private void OnEnable()
    {
        var root = inGame_mainUIDocument.rootVisualElement;

        inGame_Hud = root.Q("HUD");
        inGame_menuSettings = root.Q("Settings");
        inGame_Instructions = root.Q("Instructions");

        HudScore = inGame_Hud.Q<TextElement>("score-indicator");


        inGame_openSettingsButton = root.Q<Button>("pause-button");
        inGame_openSettingsButton.clicked += inGame_openSettingsPanel;

        inGame_closeSettingsButton = inGame_menuSettings.Q<Button>("goBack-button");
        inGame_closeSettingsButton.clicked += inGame_closeSettingsPanel;


        inGame_openInstructionsButton = inGame_menuSettings.Q<Button>("instructions-button");
        inGame_openInstructionsButton.clicked += inGame_openInstructions;

        inGame_closeInstructionsButton = inGame_Instructions.Q<Button>("close-instructions");
        inGame_closeInstructionsButton.clicked += inGame_closeInstructions;

    }

    void inGame_openSettingsPanel()
    {
        inGame_menuSettings.style.display = DisplayStyle.Flex;
        inGame_Hud.style.display = DisplayStyle.None;

    }
    void inGame_closeSettingsPanel()
    {
        inGame_menuSettings.style.display = DisplayStyle.None;
        inGame_Hud.style.display = DisplayStyle.Flex;
    }
    void inGame_openInstructions()
    {
        inGame_Instructions.style.display = DisplayStyle.Flex;
        inGame_menuSettings.style.display = DisplayStyle.None;

    }
    void inGame_closeInstructions()
    {
        inGame_Instructions.style.display = DisplayStyle.None;
        inGame_menuSettings.style.display = DisplayStyle.Flex;
    }

    string retrieveScore()
    {

        return LogicEngine.getCurrentScore().ToString() + " / 3";
    }
}
