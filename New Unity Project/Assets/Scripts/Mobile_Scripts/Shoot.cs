using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    public GameObject player_bullet;
    public float bullet_speed;

    public string Button;

	// Use this for initialization
	void Start () {
	
	}

    public void ShootBullet()
    {

        GameObject proj = Instantiate(player_bullet, transform.position + (transform.forward * 2), transform.rotation) as GameObject;
        proj.GetComponent<Rigidbody>().AddForce(transform.forward * bullet_speed, ForceMode.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Button == " ")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (Button == "a")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            if (Button == "b")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            if (Button == "c")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (Button == "d")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            if (Button == "e")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            if (Button == "f")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            if (Button == "g")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            if (Button == "h")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            if (Button == "i")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            if (Button == "j")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            if (Button == "k")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            if (Button == "l")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            if (Button == "m")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            if (Button == "n")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            if (Button == "o")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            if (Button == "p")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Button == "q")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            if (Button == "r")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (Button == "s")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            if (Button == "t")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            if (Button == "u")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            if (Button == "v")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (Button == "w")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            if (Button == "x")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            if (Button == "y")
                ShootBullet();
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            if (Button == "z")
                ShootBullet();
        }
        else if (Input.GetMouseButtonDown(0))
        {
            if (Button == "left")
                ShootBullet();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            if (Button == "right")
                ShootBullet();
        }
    }
}
