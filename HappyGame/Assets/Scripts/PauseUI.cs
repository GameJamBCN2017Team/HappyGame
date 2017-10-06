﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    private AssetBundle MyLoad;
    private string[] scenePaths;
    void Start()
    {
        //MyLoad = AssetBundle.LoadFromFile("Assets");
        //scenePaths = MyLoad.GetAllScenePaths();

    }
    void OnGUI()
    {
        GUIStyle name2 = new GUIStyle(GUI.skin.box);
        name2.fontSize = 40;
        GUIStyle name3 = new GUIStyle(GUI.skin.button);
        name3.fontSize = 30;
        GUI.color = Color.green;
        GUI.Box(new Rect(510, 160, 350, 200), "Pause", name2);
        if (GUI.Button(new Rect(560, 230, 250, 50), "Back to Menu", name3))
        {
            // Application.LoadLevel("Menu");
            // SceneManager.LoadScene(scenePaths[1], LoadSceneMode.Single);
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
       
        GUI.Button(new Rect(560, 290, 250, 50), "Exit game", name3);
    }

}