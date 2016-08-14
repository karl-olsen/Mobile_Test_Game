using UnityEngine;
using System.Collections;

public class Freeze_Rotation : MonoBehaviour {
    
    Quaternion rot;

	// Use this for initialization
	void Start () {
        rot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = rot;
	}
}
