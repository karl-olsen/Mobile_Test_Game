using UnityEngine;
using System.Collections;

public class Player_Points : MonoBehaviour {

    public float score;

    public GUIStyle score_style;

	// Use this for initialization
	void Start () {
        score = 0;
	}

    void OnGUI()
    {
        //GUI.Box(new Rect(0,30, 150, 30), "Score:" + score.ToString());
        GUI.Box(new Rect(0, Screen.height/10, Screen.width / 6, Screen.height / 10), "Score:" + score.ToString(), score_style);
    }

    public void addScore(float points)
    {
        score += points;
    }


    // Update is called once per frame
    void Update () {
	
	}
}
