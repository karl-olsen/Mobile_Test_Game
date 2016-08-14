using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {
    public GameObject Point_A;
    public GameObject Point_B;

    public float speed = 1;

    public bool face_direction = false;

    public Vector3 dir;

    bool first;

	// Use this for initialization
	void Start () {
        first = true;
    }

    void Rotate_Func()
    {

        float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
        Vector3 temp = new Vector3(0, angle + 180f, 0);

        angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
        temp = new Vector3(0, angle + 180f, 0);

        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler (temp), 4f);
        transform.rotation = Quaternion.Euler(temp);
        GetComponent<Rigidbody>().velocity = dir.normalized * speed * 0.1f;
    }


    // Update is called once per frame
    void Update () {
        if (face_direction == true)
            Rotate_Func();

	    if(first == true)
        {
            dir = Point_A.transform.position - this.transform.position;
            dir = new Vector3(dir.x, 0, dir.z);
            dir.Normalize();

            if (Vector3.Distance(this.gameObject.transform.position, Point_A.transform.position) < 0.5)
                first = false;

            transform.position = Vector3.MoveTowards(transform.position, Point_A.transform.position, speed * Time.deltaTime);

        }
        else
        {
            dir = Point_B.transform.position - this.transform.position;
            dir = new Vector3(dir.x, 0, dir.z);
            dir.Normalize();

            if (Vector3.Distance(this.gameObject.transform.position, Point_B.transform.position) < 0.5)
                first = true;

            transform.position = Vector3.MoveTowards(transform.position, Point_B.transform.position, speed * Time.deltaTime);

        }


    }
}
