using UnityEngine;
using System.Collections;

public class Damage_Enemy : MonoBehaviour {
    public int damage;

    public bool destroy_on_hit;


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<Enemy_HP>().Hurt(damage);
            if (destroy_on_hit == true)
            {
                Destroy(this.gameObject);
            }
        }
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
