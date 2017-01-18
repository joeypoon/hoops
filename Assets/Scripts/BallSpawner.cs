using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        ShootBall(KeyCode.LeftArrow);
        ShootBall(KeyCode.RightArrow);
        ShootBall(KeyCode.UpArrow);
        ShootBall(KeyCode.DownArrow);
    }

    void ShootBall(UnityEngine.KeyCode key)
    {
        int velocityMultiplier = 5;
        if (Input.GetKeyDown(key))
        {
            SpawnBall().velocity = Vector3.left * velocityMultiplier;
        }
    }

    Rigidbody SpawnBall()
    {
        return Instantiate(ballPrefab)
            .GetComponent<Rigidbody>();
    }
}
