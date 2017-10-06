using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDieCollision : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
