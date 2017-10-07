using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public GoTo gt_script;
    public Scape scape_script;
    public Rotate rot_script;
    public DestroyEntity dest_script;
    GameObject rainbow_holder;
    AudioSource collide_fx;

    public uint lifes = 3;
    public uint cur_lifes;

    public float regen_rate = 1.5f;
    private float cur_time = 0.0f;

    private float rainbow_cur_time;
    public float rainbow_tot_time;

    void Start()
    {
        gt_script = GetComponent<GoTo>();
        scape_script = GetComponent<Scape>();
        rot_script = GetComponentInChildren<Rotate>();
        dest_script = GetComponent<DestroyEntity>();
        collide_fx = GetComponent<AudioSource>();
        rainbow_holder = transform.Find("RainbowHolder").gameObject;
        rainbow_holder.SetActive(false);

        cur_lifes = lifes;
    }

    void Update()
    {
        cur_time += Time.deltaTime;
        if (cur_time > regen_rate && cur_lifes < lifes && cur_lifes > 0)
        {
            cur_lifes += 1;
            cur_time = 0.0f;
            if (cur_lifes == lifes)
            {
                gt_script.enabled = true;
            }
        }

        if (rainbow_tot_time <= rainbow_cur_time)
        {
            rainbow_holder.SetActive(false);
            rainbow_cur_time = 0.0f;
        }

        rainbow_cur_time += Time.deltaTime;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            collide_fx.Play();

            cur_time = 0.0f;
            cur_lifes = cur_lifes - 1;

            if (cur_lifes <= 0)
            {
                gt_script.enabled = false;
                rot_script.enabled = true;
                scape_script.enabled = true;
                dest_script.enabled = true;
            }

            else if (cur_lifes == (lifes - 1))
            {
                gt_script.enabled = false;
            }

            if(cur_lifes > 0)
            {
                rainbow_holder.SetActive(true);
                rainbow_cur_time = 0.0f;
            }
        }

    }


    public uint GetCurLife()
    {
        return cur_lifes;
    }
}
