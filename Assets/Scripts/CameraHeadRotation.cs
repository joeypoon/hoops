using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHeadRotation : MonoBehaviour {

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
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        transform.rotation = transform.rotation * Quaternion.Euler(-mouseY, 0, 0);
    }
}
