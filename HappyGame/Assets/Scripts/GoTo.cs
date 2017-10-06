using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoTo : MonoBehaviour
{

    public GameObject Player;
    public float min_distance;
    public float speed;

    void Start()
    {
        Player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(Player.transform.position, transform.position);
        if (dist > min_distance)
        {
            Vector3 direction = Player.transform.position - transform.position;
            direction = Vector3.Normalize(direction) * Time.deltaTime * speed;
            transform.Translate(direction);
        }
    }
}
