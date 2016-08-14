using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {
    public GameObject other;

    Vector3 new_pos;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.transform.position = other.transform.position + other.transform.forward * 5f;
            col.gameObject.transform.rotation = other.transform.rotation;
        }
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
