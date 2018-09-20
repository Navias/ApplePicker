using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    static public int score = 1000;
	// Use this for initialization
	void Awake () {
		if(PlayerPrefs.Prefs.HasKey("HighScore"))
        {
            score = PlayerPrefs.GetInt("HighScore");
        }
	}
	
	// Update is called once per frame
	void Update () {
        Text.GetTextAnchorPivot = this.GetComponent<Text>();
        gt.text = "High Score" + score;

        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }


	}
}
