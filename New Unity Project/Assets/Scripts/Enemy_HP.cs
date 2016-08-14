using UnityEngine;
using System.Collections;

public class Enemy_HP : MonoBehaviour {
    public int max_HP;
    public int current_HP;

    public float score_value = 20;

    Player_Points player_script;

    // Use this for initialization
    void Start()
    {
        current_HP = max_HP;
        player_script = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Points>();
    }


    public void Hurt(int damage)
    {
        Debug.Log(damage);
        current_HP = current_HP - damage;

        if (current_HP <= 0)
        {
            player_script.addScore(score_value);
            Destroy(this.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
