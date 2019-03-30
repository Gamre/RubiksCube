using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour {
public KeyCode pressLefttest;
public KeyCode pressRight;
public KeyCode pressUp;
public KeyCode pressDown;

public float speedH = 1.0f;
public float speedV = 2.0f;

private float yaw = 0.0f;
private float tilt = 0.0f;


	// Update is called once per frame
	void Update () {

		if(Input.GetButton("pressLeft")) {
			yaw += speedH * 2;			
			transform.eulerAngles = new Vector3(0.0f, yaw, tilt);
		}
		if(Input.GetButton("pressRight")) {
			yaw -= speedH * 2;			
			transform.eulerAngles = new Vector3(0.0f, yaw, tilt);
		}
		if(Input.GetButton("pressDown")) {
			tilt += speedV * 2;	
			if (tilt > 70) {
				tilt = 70;
			}
			transform.eulerAngles = new Vector3(0.0f, yaw, tilt);
		}
		if(Input.GetButton("pressUp")) {
			tilt -= speedV * 2;	
			if (tilt < -30.0f) {
				tilt = -30.0f;
			}		
			transform.eulerAngles = new Vector3(0.0f, yaw, tilt);
		}
			

	}
}
