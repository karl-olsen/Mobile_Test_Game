using UnityEngine;
using System.Collections;

public class Camera_Position : MonoBehaviour {
    Vector3 pos;
    Vector3 rot;

	// Use this for initialization
	void Start () {
        pos = new Vector3(2.444267e-12f, 3.38f, -4.459999f);
        rot = new Vector3(30, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = pos;
        transform.localRotation = Quaternion.Euler(rot);
	}
}
