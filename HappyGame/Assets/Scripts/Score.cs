using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    public uint score = 0;
    void OnGUI()
    {
        GUIStyle myScore = new GUIStyle(GUI.skin.box);
        myScore.fontSize = 50;
        GUI.color = Color.red;
        GUI.Box(new Rect(10, 10, 200, 60), "Score: " + score, myScore);
    }
}
