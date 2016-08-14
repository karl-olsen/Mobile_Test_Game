using UnityEngine;
using System.Collections;

public class Starsurge : MonoBehaviour {

    public GameObject AS;
    public AS_Q AS_Q_script;

    public float speed;
    public float threshold;
    public float dist;

    public Vector3 dir;

    float x;
    float y;
    float z;


	// Use this for initialization
	void Start () {
        AS = GameObject.Find("Aurelion Sol");
        AS_Q_script = AS.GetComponent<AS_Q>();
        speed = 0.4f;
        threshold = 15f;
	}

    public void Detonate()
    {
        Debug.Log("Kaboooooom");
        //damage and stun all enemies within the area of the star
        Debug.Log(dir);
        AS_Q_script.shooting = false;
        Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
            x = this.gameObject.transform.localScale.x;
            y = this.gameObject.transform.localScale.y;
            z = this.gameObject.transform.localScale.z;

            this.gameObject.transform.localScale = new Vector3(x + 0.05f, y, z + 0.05f);
            threshold += 0.05f;

            dist = Vector3.Distance(this.gameObject.transform.position, AS.transform.position);

            this.gameObject.transform.Translate(dir * Time.deltaTime * speed, Space.World);

            if (Input.GetKeyDown(KeyCode.Q))
            {
                Detonate();
            }


            if (dist > threshold)
                Detonate();
        }
}
