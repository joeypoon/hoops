using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {
    
    public float ballSpeed = 20;
    public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        ShootBall();
    }

    private void ShootBall()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            Rigidbody ball = SpawnBall();
            ball.velocity = transform.rotation * Vector3.forward * ballSpeed;
        }
    }

    private Rigidbody SpawnBall()
    {
        Rigidbody ball = Instantiate(ballPrefab)
            .GetComponent<Rigidbody>();
        ball.position = transform.position;
        return ball;
    }
}
