using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletImpact : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collision2D col)
    {
        Destroy(this.gameObject);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(this.gameObject);
    }
}
