using UnityEngine;
using System.Collections;

public class Camera_Follow_Player : MonoBehaviour {
    public GameObject player;
    // Use this for initialization

    float x;
    float y;
    Vector3 new_vec;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        x = player.transform.position.x + 10;
        y = player.transform.position.y + 10;

        this.transform.position = new Vector3(x, y, this.transform.position.z);
    }
}
