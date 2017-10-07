using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float vel = 5.0f;

    private Rigidbody rb;
    PlayerDieCollision die_script;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        die_script = GetComponent<PlayerDieCollision>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (die_script.dead == false)
        {
            float x = Input.GetAxis("Horizontal") * Time.deltaTime * vel;
            float y = Input.GetAxis("Vertical") * Time.deltaTime * vel;

            transform.Translate(x, y, 0);
            Vector3 vec = new Vector3(x, y, 0);
            this.GetComponent<Rigidbody2D>().AddForce(vec, ForceMode2D.Force);
            //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            if (transform.position.x <= -3.50f)
            {
                transform.position = new Vector3(-3.50f, transform.position.y, transform.position.z);
            }
            else if (transform.position.x >= 9.30f)
            {
                transform.position = new Vector3(9.30f, transform.position.y, transform.position.z);
            }

            if (transform.position.y <= -3.7f)
            {
                transform.position = new Vector3(transform.position.x, -3.7f, transform.position.z);
            }
            else if (transform.position.y >= 3.5f)
            {
                transform.position = new Vector3(transform.position.x, 3.5f, transform.position.z);
            }
        }
    }
}
