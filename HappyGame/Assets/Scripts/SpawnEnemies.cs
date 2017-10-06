using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

    public GameObject enemy;
    int cont = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cont++;
        if (cont >= 60)
        {
            spawn();
            cont = 0;
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
