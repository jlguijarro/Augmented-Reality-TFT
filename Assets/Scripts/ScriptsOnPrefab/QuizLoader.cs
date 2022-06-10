using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class QuizLoader : MonoBehaviour
{

    private GameObject UIQuiz;
    private UIDocument UIQuiz_visual;
    private VisualElement UIQuiz_panel;
    private Camera arCamera;
    private int layerMask;
    private ARRaycastManager arRayCastManager;
    private Vector2 touchPoisitioning = default;

    private void Awake()
    {
        arCamera = Camera.main;
        UIQuiz = GameObject.FindWithTag("UIQuiz");
        UIQuiz_visual = UIQuiz.GetComponent<UIDocument>();
        UIQuiz_panel = UIQuiz_visual.rootVisualElement.Q("quiz-panel");
        layerMask = 1 << LayerMask.NameToLayer("PrefabPlaced");

    }
 

    // Update is called once per frame
    void Update()
    {

        // Create some way to handle control and dont allow to loop conditions/bug occur

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPoisitioning = touch.position;
            if (touch.phase == TouchPhase.Began)
            {
                //Ray ray = arCamera.ScreenPointToRay(touch.position);
                Ray ray = new Ray(arCamera.transform.position, arCamera.transform.forward);
                RaycastHit hit;
                if(Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
                {
                    Debug.Log("Object collide: " + hit.collider.transform.parent);
                    UIQuiz_panel.style.display = DisplayStyle.Flex;
                }
            }
        }
        
    }
}
