﻿using UnityEngine;
using System.Collections;
public class PlayerShooting : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float power = 1500f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            Rigidbody2D instance = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;

            Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 directionVector = (target - transform.position).normalized;
            directionVector.z = 0;
            instance.AddForce(directionVector * power);
        }

    }
}