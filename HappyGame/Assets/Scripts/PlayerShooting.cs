using UnityEngine;
using System.Collections;
public class PlayerShooting : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float power = 1500f;
    public float fire_rate = 0.01f;
    private float cur_time = 0.0f;
    // Update is called once per frame
    void Update()
    {
        cur_time += Time.deltaTime;

        if (cur_time > fire_rate)
        {

            if (Input.GetButton("Fire1") || Input.GetButtonDown("Fire1"))
            {
                Rigidbody2D instance = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;

                Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector3 directionVector = (target - transform.position).normalized;
                directionVector.z = 0;
                instance.AddForce(directionVector * power);
                cur_time = 0.0f;
            }
        }
    }
}
