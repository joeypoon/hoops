﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        RotateCamera();
	}

    void RotateCamera()
    {
        float rotationSpeed = 2.0f;
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        transform.rotation = transform.rotation * Quaternion.Euler(0, mouseX, 0);
    }
}
