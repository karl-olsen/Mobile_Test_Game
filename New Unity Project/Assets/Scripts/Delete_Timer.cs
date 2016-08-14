using UnityEngine;
using System.Collections;

public class Delete_Timer : MonoBehaviour {

    public float seconds = 3f;

	// Use this for initialization
	void Start () {
        Invoke("Delete_This", seconds);
	}

    void Delete_This()
    {
        Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
