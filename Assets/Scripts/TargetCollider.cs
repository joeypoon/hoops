using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollider : MonoBehaviour {

    public int points = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<ScoreKeeper>().IncrementScore(points);
    }
}
