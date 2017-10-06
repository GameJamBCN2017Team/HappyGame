using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    GoTo gt_script;
    Scape scape_script;
    Rotate rot_script;

    public uint lifes = 3;
    private uint cur_lifes;

    public float regen_rate = 1.5f;
    private float cur_time = 0.0f;

    void Start()
    {
        gt_script = GetComponent<GoTo>();
        scape_script = GetComponent<Scape>();
        rot_script = GetComponent<Rotate>();

        cur_lifes = lifes;
    }

    void Update()
    {
        cur_time += Time.deltaTime;
        if (cur_time > regen_rate && cur_lifes < lifes)
        {
            cur_lifes += 1;
            cur_time = 0.0f;
            if (cur_lifes == lifes)
            {
                gt_script.enabled = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            cur_time = 0.0f;
            cur_lifes = cur_lifes - 1;

            if (cur_lifes <= 0)
            {
                gt_script.enabled = false;
                rot_script.enabled = true;
                scape_script.enabled = true;
            }

            else if (cur_lifes == (lifes - 1))
            {
                gt_script.enabled = false;
            }
        }

    }



}
