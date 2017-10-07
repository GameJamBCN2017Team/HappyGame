using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    void OnGUI()
    {
        GUIStyle name2 = new GUIStyle(GUI.skin.box);
        name2.fontSize = 40;
        GUIStyle name3 = new GUIStyle(GUI.skin.button);
        name3.fontSize = 30;
        GUI.color = Color.green;
        GUI.Box(new Rect(510, 230, 350, 200), "Pause", name2);
        if (GUI.Button(new Rect(560, 300, 250, 50), "Back to Menu", name3))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
            SceneManager.UnloadScene("HappyGame");
        }
       
       if (GUI.Button(new Rect(560, 360, 250, 50), "Exit game", name3))
        {
            Application.Quit();
        }
    }

}
