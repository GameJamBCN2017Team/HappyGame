using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    Text text;
    PlayerDieCollision p_die_script;
        
    private float timer;

    
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        timer = 0.0f;
        p_die_script = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDieCollision>();
	}
	
	// Update is called once per frame
	void Update () {
        if (p_die_script.dead == false) timer += Time.deltaTime;

        float val = Mathf.Round(timer * 100.0f) / 100.0f;
        text.text = val.ToString();
    }
}
