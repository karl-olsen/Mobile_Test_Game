using UnityEngine;
using System.Collections;

public class Touch_Delete : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray touchRay = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(touchRay, out hit))
            {
                if (hit.collider.gameObject == this.gameObject)
                {
                    Destroy(this.gameObject);
                }
            }

        }
    }
}
