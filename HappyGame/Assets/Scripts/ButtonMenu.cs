using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour {

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
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        SceneManager.UnloadScene("HappyGame");
    }
}
