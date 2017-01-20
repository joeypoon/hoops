using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAbsorber : MonoBehaviour {

    public int score = 0;
    private ScoreKeeper scoreKeeper;
    private Text scoreDisplay;

	// Use this for initialization
	void Start () {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        if (scoreKeeper)
        {
            score = scoreKeeper.score;
            Destroy(scoreKeeper.gameObject);
        }

        scoreDisplay = GetComponent<Text>();
        scoreDisplay.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
