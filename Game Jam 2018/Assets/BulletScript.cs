using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour 
{
	public float xfire;
	public float yfire;

	// Use this for initialization
	void Start () 
	{
		xfire = Input.GetAxis ("Right Joystick X");
		yfire = Input.GetAxis ("Right Joystick Y");

		if (xfire >= 0.2) 
		{
			xfire = 5;
		}
		if (xfire <= -0.2)
		{
			xfire = -5;
		}

		if (yfire >= -0.2) 
		{
			yfire = 5;
		}
		if (yfire <= 0.2)
		{
			yfire = -5;
		}

		GetComponent<Rigidbody> ().velocity = new Vector3 (xfire, yfire, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
