using UnityEngine;
using System.Collections;

public class Player_Health : MonoBehaviour {
    public int max_HP;
    public int current_HP;

    public GUIStyle hp_style;

    // Use this for initialization
    void Start () {
        current_HP = max_HP;
	}


    void OnGUI ()
    {
        //GUI.Box(new Rect(0, 0, 150, 30), "Player Health:" + current_HP.ToString());
        GUI.Box(new Rect(0, 0, Screen.width/6, Screen.height/10), "HP:" + current_HP.ToString(), hp_style);
    }

    public void Hurt(int damage)
    {
        Debug.Log(damage);
        current_HP = current_HP - damage;

        if(current_HP <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void Heal(int amount)
    {
        Debug.Log(amount);
        current_HP = current_HP + amount;

        if (current_HP > max_HP)
            current_HP = max_HP;
    }


    // Update is called once per frame
    void Update () {
	
	}
}
