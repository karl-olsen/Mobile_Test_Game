using UnityEngine;
using System.Collections;

public class Player_Shoot : MonoBehaviour {

	public GameObject claw;
	public GameObject aimer;
	public bool shooting;
	public bool pulling;

	public float thrust;

	Vector3 claw_dir;

	// Use this for initialization
	void Start () {
		thrust = 1000f;
		shooting = false;
		pulling = false;
		aimer = GameObject.Find ("Aimer");
		claw_dir = Vector3.zero;
	}

	public void pull()	{
		claw_dir = (claw.transform.position - this.transform.position);
		claw_dir.Normalize ();
		Debug.Log (claw_dir);
		shooting = false;
		GetComponent<Rigidbody>().AddRelativeForce (claw_dir * thrust, ForceMode.Force);
		return;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("CLICK DETECTED");
			if (shooting == false) {
				Debug.Log ("SHOOTING");
				shooting = true;

				Instantiate(claw, aimer.transform.position, aimer.transform.rotation);
			}
		}
	}
}
