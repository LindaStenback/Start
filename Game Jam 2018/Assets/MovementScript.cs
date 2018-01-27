using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour 
{
	private Vector3 movementVector;

	private CharacterController characterController;

	public float movementSpeed = 8;

	public float xfire;

	public float yfire;

	public Transform bulletShot;

	public float shotDelay;


	// Use this for initialization
	void Start () 
	{
		characterController = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		movementVector.x = Input.GetAxis ("Left Joystick X") * movementSpeed;

		movementVector.y = Input.GetAxis ("Left Joystick Y") * movementSpeed;

		xfire = Input.GetAxis ("Right Joystick X");

		yfire = Input.GetAxis ("Right Joystick Y");

		characterController.Move (movementVector * Time.deltaTime);

		if (((xfire > 0.2 || xfire < -0.2)) & (shotDelay == 0))
		{
			shotDelay = 1;
			Instantiate (bulletShot, transform.position, bulletShot.rotation);
			StartCoroutine(delayRest());
		}

		if (((yfire > 0.2 || yfire < -0.2)) & (shotDelay == 0))
		{
			shotDelay = 1;
			Instantiate (bulletShot, transform.position, bulletShot.rotation);
			StartCoroutine(delayRest());
		}
	}

	IEnumerator delayRest()
	{
		yield return new WaitForSeconds (0.1f);
		shotDelay = 0;
	}
}
