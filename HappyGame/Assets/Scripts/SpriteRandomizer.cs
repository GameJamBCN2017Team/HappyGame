using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRandomizer : MonoBehaviour {

    SpriteRenderer sr;

	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
        int val = (int)(Random.value * 10);
        if (val > 8) val = 8;
        string str = "message";
        str += val.ToString();
        sr.sprite = gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load(str, typeof(Sprite)) as Sprite;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
