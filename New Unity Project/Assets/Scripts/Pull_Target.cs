using UnityEngine;
using System.Collections;

public class Pull_Target : MonoBehaviour {
    public GameObject target;

    bool CD = false;

	// Use this for initialization
	void Start () {
        
	}
    
    void Pull()
    {
        target.transform.position = Vector3.Lerp(target.transform.position, transform.position, Time.deltaTime);
    }

	
	// Update is called once per frame
	void Update () {
            Pull();
	}
}
