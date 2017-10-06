using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    GoTo gt_script;
    Scape scape_script;
    Rotate rot_script;

    public uint lifes = 3;

    void Start()
    {
        gt_script = GetComponent<GoTo>();
        scape_script = GetComponent<Scape>();
        rot_script = GetComponent<Rotate>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            lifes = lifes - 1;
        }
        if (lifes <= 0)
        {
            gt_script.enabled = false;
            rot_script.enabled = true;
            scape_script.enabled = true;
        }
    }



}
