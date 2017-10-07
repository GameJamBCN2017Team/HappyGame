﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDieCollision : MonoBehaviour {

    public bool dead = false;
    public AudioSource music;

    public float die_delay;
    private float cur_time;

    GameObject spawner;

    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner");
    }

    void Update()
    {
        cur_time += Time.deltaTime;
        if (dead)
        {
            if (cur_time >= die_delay)
            {
                SceneManager.LoadScene("TryAgain", LoadSceneMode.Single);
                SceneManager.UnloadScene("HappyGame");
            }
            Vector2 vec = Random.insideUnitCircle * 0.05f;
            vec.x += transform.position.x;
            vec.y += transform.position.y;
            transform.position = vec;
        }


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            music.Play();
            dead = true;
            cur_time = 0.0f;
            spawner.GetComponent<SpawnEnemies>().enabled = false;

            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach(GameObject enemie in enemies)
            {
                enemie.GetComponent<Rotate>().enabled = true;
                enemie.GetComponent<DestroyEntity>().enabled = true;
                enemie.GetComponent<Scape>().enabled = true;
                enemie.GetComponent<GoTo>().enabled = false;
                enemie.GetComponent<EnemyLife>().cur_lifes = 0;
            }
        }
    }
}
