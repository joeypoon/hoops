using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
        Instantiate(ballPrefab);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
