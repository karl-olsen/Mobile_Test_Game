using UnityEngine;
using System.Collections;

public class Player_Turning_Movement : MonoBehaviour {

    public float speed = 1;

    float run_speed;

    public float RotateSpeed = 1;

    public float jump_height = 8;

    public bool is_falling = false;

    Rigidbody this_rb;


    //constant scale (to prevent changing local/global scale when parenting to moving platform)
    Vector3 unparent_sc = new Vector3(1, 1, 1);

    Vector3 parent_sc = new Vector3(0.249f, 2.141221f, 0.1675f);

    // Use this for initialization
    void Start () {
        this_rb = this.gameObject.GetComponent<Rigidbody>();
        run_speed = speed;
	}

    void OnCollisionEnter(Collision col)
    {
        if (is_falling == true)
        {
            if (col.gameObject.tag == "Floor" || col.gameObject.tag == "Moving_Platform")
                is_falling = false;
        }

        //parent player to the platform when landing on it in order to have player move with it
        if (col.gameObject.tag == "Moving_Platform")
        {
            transform.parent = col.gameObject.transform.GetChild(0);
        }
    }

    void OnCollisionExit(Collision col)
    {
        //when player jumps/falls off platform, unparent the player from it
        if (col.gameObject.tag == "Moving_Platform")
        {
            transform.parent = null;
        }
        if (col.gameObject.tag == "Moving_Platform" || col.gameObject.tag == "Floor")
        {
            is_falling = true;
        }
    }




    //move right loop
    public IEnumerator TurnRight()
    {
        while(true)
        {
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime, Space.Self);
            yield return null;
        }
    }

    //button calls this function to start moving right loop
    public void StartRight()
    {
        StartCoroutine("TurnRight");
    }
    
    public IEnumerator TurnLeft()
    {
        while (true)
        {
            transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime, Space.Self);
            yield return null;
        }
    }

    public void StartLeft()
    {
        StartCoroutine("TurnLeft");
    }

    public IEnumerator MoveUp()
    {
        while(true)
        {
            transform.Translate(Vector3.forward * 0.1f * speed);
            yield return null;
        }
    }

    public void StartUp()
    {
        StartCoroutine("MoveUp");
    }

    public IEnumerator MoveDown()
    {
        while (true)
        {
            transform.Translate(Vector3.back * 0.1f * speed);
            yield return null;
        }
    }

    public void StartDown()
    {
        StartCoroutine("MoveDown");
    }

    public void Jump()
    {
        if (is_falling == false)
        {
            is_falling = true;
            this_rb.velocity = new Vector3(0, jump_height, 0);
        }
    }

    void OnCollisionStay()
    {
        is_falling = false;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * 0.1f * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * -0.1f * speed);
        }

        if (Input.GetKeyDown(KeyCode.Space) && is_falling == false)
            Jump();


        if (transform.parent == null)
            transform.localScale = unparent_sc;
        else
            transform.localScale = parent_sc;
    }


}
