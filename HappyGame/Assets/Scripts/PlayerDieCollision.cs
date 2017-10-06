using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDieCollision : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("TryAgain", LoadSceneMode.Single);
            SceneManager.UnloadScene("HappyGame");
        }
    }
}
