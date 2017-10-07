using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

    public GameObject enemy;
    
    bool pause = false;

    public float upgrade_rate = 7.0f;
    public float upgrade_scale = 0.9f;
    public float spawn_rate = 2.0f;

    private float upgrade_rate_timer = 0.0f;
    private float spawn_rate_timer = 0.0f;


    // Update is called once per frame
    void Update()
    {
        if (pause == true) return;

        upgrade_rate_timer += Time.deltaTime;
        spawn_rate_timer += Time.deltaTime;

        if(upgrade_rate <= upgrade_rate_timer)
        {
            spawn_rate *= upgrade_scale;
            upgrade_rate_timer = 0.0f;
        }

        if(spawn_rate <= spawn_rate_timer)
        {
            spawn();
            spawn_rate_timer = 0.0f;
        }
    }

    void spawn()
    {
        float x = Random.Range(-15.0f, 15.0f);
        float y = Random.Range(-6.5f, 6.5f);

        if (x < 10.5 && x > -10.5 || y < 5.5 && y > -5.5)
        {
            if (x < 10.5 && x > -10.5)
            {
                while (y < 5.5 && y > -5.5)
                {
                    y = Random.Range(-6.5f, 6.5f);
                }
            }
            if (y < 5.5 && y > -5.5)
            {
                while (x < 10.5 && x > -10.5)
                {
                    x = Random.Range(-15.0f, 15.0f);
                }
            }
        }
        Vector3 position = new Vector3(x, y, 0);
        Instantiate(enemy, position, Quaternion.identity);
    }

}
