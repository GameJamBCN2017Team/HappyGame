using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float vel = 5.0f;

    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * vel;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * vel;

        transform.Translate(x, y, 0);
        Vector3 vec = new Vector3(x, y, 0);
        this.GetComponent<Rigidbody2D>().AddForce(vec, ForceMode2D.Force);
        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        if (transform.position.x <= -10.0f)
        {
            transform.position = new Vector3(-10.0f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= 10.0f)
        {
            transform.position = new Vector3(10.0f, transform.position.y, transform.position.z);
        }

        if (transform.position.y <= -4.5f)
        {
            transform.position = new Vector3(transform.position.x, -4.5f, transform.position.z);
        }
        else if (transform.position.y >= 4.5f)
        {
            transform.position = new Vector3(transform.position.x, 4.5f, transform.position.z);
        }
    }
}