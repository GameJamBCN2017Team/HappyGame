using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationManager : MonoBehaviour {

    EnemyLife enemy_life_script;
    public Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        enemy_life_script = GetComponent<EnemyLife>();

    }
	
	// Update is called once per frame
	void Update () {
        uint cur_life = enemy_life_script.GetCurLife();
        uint lifes = enemy_life_script.lifes;
        if (cur_life == lifes)
        {
            anim.Play("EnemyAngry");
        }
		if(cur_life == (lifes - 1) )
        {
            anim.Play("EnemyConfused");
        }
        if(cur_life == (lifes - 2))
        {
            anim.Play("EnemyNeutral");
        }
        if(cur_life == 0)
        {
            anim.Play("EnemySmile");
        }
	}
}
