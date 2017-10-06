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

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);


        //rb.AddForce(movement);
    }
}
