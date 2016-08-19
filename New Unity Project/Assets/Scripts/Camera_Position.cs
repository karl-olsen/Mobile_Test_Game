using UnityEngine;
using System.Collections;

public class Camera_Position : MonoBehaviour {
    Vector3 pos;
    Vector3 rot;

	// Use this for initialization
	void Start () {
        pos = new Vector3(-4.768424e-09f, 0.7399998f, -4.459999f);
        rot = new Vector3(16, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = pos;
        transform.localRotation = Quaternion.Euler(rot);
	}
}
