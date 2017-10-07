using UnityEngine;
using System.Collections;
public class PlayerShooting : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float power = 1500f;
    public float fire_rate = 0.01f;
    private float cur_time = 0.0f;

    private Rigidbody2D instance;

    public float shoot_delay = 0.2f;
    private float shoot_delay_timer;
    public float max_spawn_dist = 3.0f;
    private float cur_spawn_dist;

    AudioSource shoot_fx;

    void Start()
    {
        shoot_fx = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        cur_time += Time.deltaTime;
        shoot_delay_timer += Time.deltaTime;

        if (cur_time > fire_rate)
        {
            if (Input.GetButton("Fire1") || Input.GetButtonDown("Fire1"))
            {
                instance = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
                shoot_fx.Play();

                cur_time = 0.0f;
                shoot_delay_timer = 0.0f;
                cur_spawn_dist = 0.0f;
            }
        }

        Vector3 target_ = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction_vector = (target_ - transform.position).normalized;

        cur_spawn_dist = max_spawn_dist * (shoot_delay_timer / (shoot_delay * 0.8f));
        if (cur_spawn_dist > max_spawn_dist) cur_spawn_dist = max_spawn_dist;

        float angle = Mathf.Atan2(direction_vector.x, direction_vector.y) * Mathf.Rad2Deg;
        Quaternion angle_quat = Quaternion.AngleAxis(-angle, Vector3.forward);
        instance.transform.rotation = angle_quat;
        instance.transform.position = transform.position + (direction_vector.normalized * cur_spawn_dist);

        if (shoot_delay_timer > shoot_delay)
        {
            Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 directionVector = (target - transform.position).normalized;
            instance.AddForce(directionVector * power);

            instance = null;

            shoot_delay_timer = 0.0f;
        }
    }
}
