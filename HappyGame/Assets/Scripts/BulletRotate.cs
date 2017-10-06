using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRotate : MonoBehaviour {

    public float vel = 10;

	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, vel * Time.deltaTime); // Rotate the bullet respecting the rotation vel
	}
}
