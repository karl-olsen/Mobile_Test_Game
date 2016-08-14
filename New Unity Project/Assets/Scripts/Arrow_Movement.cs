using UnityEngine;
using System.Collections;

public class Arrow_Movement : MonoBehaviour {
    public float speed = 1;

    public float jump_height = 8;

    bool is_falling = false;

    Rigidbody this_rb;


    // Use this for initialization
    void Start () {
        this_rb = this.gameObject.GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        if (is_falling == false)
        {
            this_rb.velocity = new Vector3(0, jump_height, 0);
            is_falling = true;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        //reset is_falling bool upon landing on a floor/platform object
        if(is_falling == true)
        {
            if (col.gameObject.tag == "Floor" || col.gameObject.tag == "Moving_Platform")
                is_falling = false;
        }

        //parent player to the platform when landing on it in order to have player move with it
        if(col.gameObject.tag == "Moving_Platform")
        {
            transform.parent = col.gameObject.transform;
        }
    }

    void OnCollisionExit(Collision col)
    {
        //when player jumps/falls off platform, unparent the player from it
        if(col.gameObject.tag == "Moving_Platform")
        {
            transform.parent = null;
        }
    }

    //move right loop
    public IEnumerator MoveRight()
    {
        transform.Translate(Vector3.right * 0.1f * speed);
        yield return null;
        StartCoroutine(MoveRight());
    }

    //button calls this function to start moving right loop
    public void StartRight()
    {
        StartCoroutine(MoveRight());
    }

    public IEnumerator MoveLeft()
    {
        transform.Translate(Vector3.left * 0.1f * speed);
        yield return null;
        StartCoroutine(MoveLeft());
    }

    public void StartLeft()
    {
        StartCoroutine(MoveLeft());
    }

    public IEnumerator MoveUp()
    {
        transform.Translate(Vector3.forward * 0.1f * speed);
        yield return null;
        StartCoroutine(MoveUp());
    }

    public void StartUp()
    {
        StartCoroutine(MoveUp());
    }

    public IEnumerator MoveDown()
    {
        transform.Translate(Vector3.back * 0.1f * speed);
        yield return null;
        StartCoroutine(MoveDown());
    }

    public void StartDown()
    {
        StartCoroutine(MoveDown());
    }

    // Update is called once per frame
    void Update () {
        //debugging keyboard controls
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * 0.1f * speed);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * 0.1f * speed);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * 0.1f * speed);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * 0.1f * speed);

        if (Input.GetKey(KeyCode.Space))
            Jump();
    }
}
