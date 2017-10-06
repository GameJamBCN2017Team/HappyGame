using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;

            }

            else
                Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else
                Time.timeScale = 1;
        }

    }
}
