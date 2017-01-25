using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

    public int score = 0;
    private ScoreSound scoreSound;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
        scoreSound = FindObjectOfType<ScoreSound>();
	}

    public void IncrementScore(int points)
    {
        score += points;
        scoreSound.PlayChime();
    }
}
