using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pause : MonoBehaviour
{
    public GameObject UI;

    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            UI.SetActive(true);
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;

            }

            else
                Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            UI.SetActive(false);
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else
                Time.timeScale = 1;
        }

    }
}
