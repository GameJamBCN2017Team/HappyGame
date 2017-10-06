﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDieCollision : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
