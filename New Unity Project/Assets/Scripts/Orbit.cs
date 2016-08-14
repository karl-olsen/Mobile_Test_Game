using UnityEngine;
using System.Collections;

//*****************************************************************************************************
//***WITH SPEED SET TO 40F, THE AMOUNT OF TIME FOR A STAR TO MAKE ONE WHOLE ROTATION IS 9 SECONDS******
//*****************************************************************************************************

public class Orbit : MonoBehaviour {

	public GameObject parent;
	public float speed;

    public float dist;

	public bool outer;

	// Use this for initialization
	void Start () {
		parent = GameObject.Find ("Orbit_Tracker");
		speed = 80f;
	}

	void LateUpdate()	{
		transform.rotation = Quaternion.identity;
	}

	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(parent.transform.position, Vector3.up, speed * Time.deltaTime);


        dist = Vector3.Distance(this.gameObject.transform.position, parent.transform.position);


        //tracking amount of time per revolution
		//if (id == 1 && this.gameObject.transform.localPosition.z > 1.99)
		//	Debug.Log (Time.time);

	}
}
