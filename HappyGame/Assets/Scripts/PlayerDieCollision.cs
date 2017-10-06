using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDieCollision : MonoBehaviour {

    public bool dead = false;

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            dead = true;
            SceneManager.LoadScene("TryAgain", LoadSceneMode.Single);
            SceneManager.UnloadScene("HappyGame");
        }
    }
}
