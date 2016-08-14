using UnityEngine;
using System.Collections;

public class Wheel_Turn : MonoBehaviour {
    public GameObject parent;


	// Use this for initialization
	void Start () {
        parent = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(parent.transform.position, Vector3.forward, Time.deltaTime * 10f);
        transform.localRotation = Quaternion.Euler(Vector3.zero);
    }
}
