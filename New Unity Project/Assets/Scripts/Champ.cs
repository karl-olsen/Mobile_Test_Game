using UnityEngine;
using System.Collections;

public class Champ : MonoBehaviour {
    Vector3 dir;
    public Vector3 target_location;
    public float target_distance;
    public Rigidbody rb;

    public float move_speed;
    public float turn_speed;

    //need to set public "ambiguous" Q W E R scripts that don't require names
    public AS_Q Q_script;

    // Use this for initialization
    void Start () {
        rb = this.gameObject.GetComponent<Rigidbody>();
        move_speed = 16f;
        turn_speed = 4f;
    }
    
    public void callQ()
    {
        Debug.Log("PEW");
        if(Q_script.shooting == false) 
            Q_script.Call();
    }


    void Path()
    {
        dir = this.gameObject.transform.position - target_location;
        target_distance = Vector3.Distance(this.transform.position, target_location);

        //3 raycasts: left, center, right
        //if center cast is blocked
        //if left is blocked, turn right
        //else turn left

        rb.MovePosition(transform.position + transform.forward * Time.deltaTime * move_speed);

        //update target_distance
        target_distance = Vector3.Distance(this.transform.position, target_location);
    }

    void Rotate_Func()
    {

        float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
        Vector3 temp = new Vector3(0, angle + 180f, 0);

        angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
        temp = new Vector3(0, angle + 180f, 0);

        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler (temp), 4f);
        transform.rotation = Quaternion.Euler(temp);
        //GetComponent<Rigidbody>().velocity = dir.normalized * turn_speed;
    }

    public void setTarget(GameObject g)
    {
        if (g.name != "Floor")
            setTargetLocation(g.gameObject.transform.position);
    }

    public void setTargetLocation(Vector3 l)
    {
        target_location = l;
        Path();
    }

    // Update is called once per frame
    void Update () {

        if(Input.GetKeyDown(KeyCode.Q))
        {
            callQ();

        }




        Rotate_Func();

        if (target_distance > 3f)
        {
            Path();
        }

        if (Input.GetMouseButton(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.gameObject.name == "Floor")
                {
                    setTarget(hit.collider.gameObject);
                    setTargetLocation(hit.point);
                }
            }

        }

    }
}
