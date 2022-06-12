using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UIElements;

public class QuizPrefabControllerRed : MonoBehaviour
{
    private GameObject UIQuiz;
    private UIDocument UIQuiz_visual;
    private VisualElement UIQuiz_panel;
    private Camera arCamera;
    private int layerMask;
    private ARRaycastManager arRayCastManager;
    private Vector2 touchPoisitioning = default;
    private string prefabName;

    private void Awake()
    {
        arCamera = Camera.main;
        UIQuiz = GameObject.FindWithTag("UIQuiz");
        // UIQuiz_visual = UIQuiz.GetComponent<UIDocument>();
        // UIQuiz_panel = UIQuiz_visual.rootVisualElement.Q("quiz-panel");
        layerMask = 1 << LayerMask.NameToLayer("PrefabPlaced");
        // getProperName();

    }
    // Update is called once per frame
    void Update()
    {

        // Create some way to handle control and dont allow to loop conditions/bug occur
        rotateQuiz();
        if (Input.touchCount > 0 && LogicEngine.IsNotActive())
        {
            Touch touch = Input.GetTouch(0);
            touchPoisitioning = touch.position;
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                // Ray ray = new Ray(arCamera.transform.position, arCamera.transform.forward);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
                {
                    Debug.Log("This object name:" + hit.collider.name);
                    trimThatName(hit.collider.name);
                    LogicEngine.setActiveQuiz(prefabName);
                    UIQuiz.GetComponent<UIQuiz>().loadQuiz();
                    // UIQuiz_panel.style.display = DisplayStyle.Flex;
                }
            }
        }

    }

    private void rotateQuiz()
    {
        transform.Rotate(0f, 20.4f * Time.deltaTime, 0f);
    }

    private void trimThatName(string theName)
    {
        prefabName = theName.Split('-')[0];

    }
}
