using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEntity : MonoBehaviour {

    public float del_time = 5.0f;
    private float cur_time = 0.0f;

	// Update is called once per frame
	void Update () {
        cur_time += Time.deltaTime;
        if(cur_time >= del_time)
        {
            Destroy(this.gameObject);
        }
	}
}
