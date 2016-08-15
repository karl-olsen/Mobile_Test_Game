using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour {
    public GameObject center;

    public float speed = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(center.transform.position, Vector3.up, 20 * Time.deltaTime * speed);
	}
}
