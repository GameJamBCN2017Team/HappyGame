using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonExit : MonoBehaviour
{
    public Button test;
    // Use this for initialization
    void Start()
    {
        Button btn = test.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void TaskOnClick()
    {
        Application.Quit();
    }
}