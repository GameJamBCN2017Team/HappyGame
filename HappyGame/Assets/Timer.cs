using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    Text text;

    private float timer;
    //Text text 
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        timer = 0.0f;	
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        float val = Mathf.Round(timer * 100.0f) / 100.0f;
        text.text = val.ToString();
    }
}
