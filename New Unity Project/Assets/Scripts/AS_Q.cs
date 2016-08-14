using UnityEngine;
using System.Collections;

public class AS_Q : MonoBehaviour {

    public GameObject projectile;
    public GameObject active_pro;
    public Starsurge pro_script;
    public Vector3 dir;
    public Vector3 speed;

    public bool shooting;

	// Use this for initialization
	void Start () {
        shooting = false;
	}

    IEnumerator WaitForInput()
    {
        while(!Input.GetMouseButtonDown(0) && !Input.GetMouseButtonDown(1))
            yield return null;

        if (Input.GetMouseButtonDown(1))
        {
            //Debug.Log("RIGHT CLICK");
        }
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("LEFT CLICK");
            //get mouse position
            Vector3 mouse_pos = new Vector3(0, 0, 0);
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
                mouse_pos = hit.point;
            Debug.Log("mouse:" + mouse_pos);
            //find "dir" relative from AS to mouse position
            dir = mouse_pos - this.gameObject.transform.position;
            //the dir should not involve vertical movement (y axis)
            dir = new Vector3(dir.x, 0, dir.z);
            Vector3.Normalize(dir);
            Debug.Log("Aurelion: " + this.gameObject.transform.position);
            Debug.Log("dir: " + dir);
            Debug.DrawRay(this.gameObject.transform.position, dir, Color.red);

            active_pro = (GameObject)Instantiate(projectile, this.gameObject.transform.position, Quaternion.Euler(0, 0, 0));
            pro_script = active_pro.GetComponent<Starsurge>();
            pro_script.dir = dir;
        }
    }

    public void Call()
    {
        shooting = true;
        StartCoroutine("WaitForInput");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
