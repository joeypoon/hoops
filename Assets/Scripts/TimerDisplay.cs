using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour {

    LevelManager levelManager;
    Text timerDisplay;

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
        timerDisplay = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timerDisplay.text = "Time: " + levelManager.timer;
	}
}
