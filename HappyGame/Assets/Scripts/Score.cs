using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    public uint score = 0;
    void OnGUI()
    {
        GUIStyle myScore = new GUIStyle(GUI.skin.box);
        myScore.fontSize = 20;
        GUI.color = Color.red;
        GUI.Box(new Rect(460, 720, 100, 30), "Score: " + score, myScore);
    }
}
