using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {
    
    public float ballSpeed = 7;
    public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        ShootBall();
    }

    void ShootBall()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            SpawnBall().velocity = Vector3.forward * ballSpeed;
        }
    }

    Rigidbody SpawnBall()
    {
        Rigidbody ball = Instantiate(ballPrefab)
            .GetComponent<Rigidbody>();
        ball.position = transform.position;
        return ball;
    }
}
