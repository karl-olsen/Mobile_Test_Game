using UnityEngine;
using System.Collections;

public class AS_Passive : MonoBehaviour {

    public float base_damage;
    public float W_bonus;
    public float AP_scaling;

    public int AS_level;
    public int W_level;

    public float dist;
    public float inner_dist;
    public float outer_dist;

    public int id;

    public bool outer;

    // Use this for initialization
    void Start()
    {
        outer = false;

        base_damage = 20;
        W_bonus = 0;
        AP_scaling = 0.17f;

        AS_level = 1;
        W_level = 0;

        dist = 0;
        inner_dist = 6;
        outer_dist = 12;

        if (this.gameObject.name == "LITTLE 1")
            id = 1;
        else if (this.gameObject.name == "LITTLE 2")
            id = 2;
        else if (this.gameObject.name == "LITTLE 3")
            id = 3;
        else
            id = 0;

    }

    public void Expand()
    {
        //depending on id, make target position the id's respective "Outer" object

    }

    public void Retract()
    {
        //depending on id, make target position the id's respective "Inner" object

    }

    public void updateDamage()
    {
        if (AS_level > 6)
            base_damage = 18 + (AS_level * 2);
        else if (AS_level > 10)
            base_damage = 13 + (AS_level * 3);
        else if (AS_level > 14)
            base_damage = (AS_level - 1) * 5;
        else if (AS_level > 17)
            base_damage = 60 + (AS_level * 7);
        else
            base_damage = 88 + (AS_level - 17) * 9;

        W_bonus = W_level * 10;
        AP_scaling = 0.17f + (AS_level / 100);
    }

    void LateUpdate()
    {
        transform.rotation = Quaternion.identity;
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            outer = !outer;
        }

        //if (id == 1 && this.gameObject.transform.localPosition.z > 1.99)
        //	Debug.Log (Time.time);

    }
}
