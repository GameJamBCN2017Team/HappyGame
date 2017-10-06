using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour {

    public Animator anim;
    PlayerDieCollision die_script;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        die_script = GetComponent<PlayerDieCollision>();
    }
	
	// Update is called once per frame
	void Update () {
		if(die_script.dead == true)
        {
            anim.Play("PlayerDead");
        }
	}
}
