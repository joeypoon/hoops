using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    Text textDisplay;
    ScoreKeeper scoreKeeper;

	// Use this for initialization
	void Start () {
        textDisplay = GetComponent<Text>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
        textDisplay.text = "Score: " + scoreKeeper.score;
	}
}
