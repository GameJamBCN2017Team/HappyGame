using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDieCollision : MonoBehaviour {

    public bool dead = false;
    public AudioSource music;

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            music.Play();
            dead = true;
            SceneManager.LoadScene("TryAgain", LoadSceneMode.Single);
            SceneManager.UnloadScene("HappyGame");
        }
    }
}
