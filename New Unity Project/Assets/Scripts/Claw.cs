using UnityEngine;
using System.Collections;

public class Claw : MonoBehaviour {
	public Player_Shoot p_script;
	public GameObject player;

	public float thrust;

	// Use this for initialization
	void Start () {
		thrust = 1000f;
		player = GameObject.Find ("Player");
		p_script = GameObject.Find ("Player").GetComponent<Player_Shoot> ();
		GetComponent<Rigidbody>().AddRelativeForce (Vector3.forward * thrust, ForceMode.Force);
	}

	void OnCollisionEnter(Collision g)	{
		if (g.gameObject.name == "Floor" || g.gameObject.name == "Ceiling") {
			reset ();
			Destroy (this.gameObject);
		} 
		else if (g.gameObject.tag == "Wall") {
			GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
			p_script.pulling = true;
			p_script.pull();
		}
	}

	void reset()	{
		p_script.shooting = false;
	}
	
	// Update is called once per frame
	void Update () {


	}
}
