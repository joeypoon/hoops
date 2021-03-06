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

    private void RotateCamera()
    {
        float rotationSpeed = 5;
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        transform.localRotation = transform.localRotation * Quaternion.Euler(0, mouseX, 0);
        Camera childCamera = GetComponentInChildren<Camera>();
        childCamera.transform.localRotation = childCamera.transform.localRotation * Quaternion.Euler(-mouseY, 0, 0);
    }
}
