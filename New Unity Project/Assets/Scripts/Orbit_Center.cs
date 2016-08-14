using UnityEngine;
using System.Collections;

public class Orbit_Center : MonoBehaviour {
	public GameObject AS;

	// Use this for initialization
	void Start () {
		AS = GameObject.Find ("Aurelion Sol");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = AS.transform.position;
	}
}
