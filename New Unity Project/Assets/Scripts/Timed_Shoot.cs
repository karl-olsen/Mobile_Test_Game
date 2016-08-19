using UnityEngine;
using System.Collections;

public class Timed_Shoot : MonoBehaviour {

    public GameObject bullet;
    public float bullet_speed = 1;

    public float time_between_shots = 1;
    public float delay = 0f;

    // Use this for initialization
    void Start () {
        InvokeRepeating("Shoot", delay, time_between_shots);
    }

    void Shoot()
    {
        GameObject proj = Instantiate(bullet, transform.position + (transform.forward * 2), transform.rotation) as GameObject;
        proj.GetComponent<Rigidbody>().AddForce(transform.forward * bullet_speed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
