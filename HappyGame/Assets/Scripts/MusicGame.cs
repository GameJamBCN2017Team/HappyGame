using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicGame : MonoBehaviour {
    public GameObject music1;
    public GameObject music2;
	// Use this for initialization
    void Start()
    {
        StartCoroutine("Music");
    }
	IEnumerator Music () {
        print(Time.time);
        yield return new WaitForSeconds(6f);
        print(Time.time);
        music1.SetActive(false);
        music2.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
