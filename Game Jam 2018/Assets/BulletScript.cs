using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour 
{
	public float xfire;
	public float yfire;
	public float shotSpeed = 5;
	public int playerNo;

	// Use this for initialization
	void Start () 
	{
<<<<<<< HEAD
		if (playerNo == 1) 
		{
			xfire = Input.GetAxis ("xShoot")* shotSpeed;
			yfire = Input.GetAxis ("yShoot")* shotSpeed;
		} 
		else 
		{
			xfire = Input.GetAxis ("xShootP2")* shotSpeed;
			yfire = Input.GetAxis ("yShootP2")* shotSpeed;
		}


		GetComponent<Rigidbody> ().velocity = new Vector3 (xfire, yfire, 0);
=======
		
>>>>>>> 34c0b5faa629df47a38f786dc7ed5833771ed6ac
	}
	
	// Update is called once per frame
	void Update () 
	{
        BulletFire();

    }

   void BulletFire()
    {
        xfire = Input.GetAxis("Right Joystick X");
        yfire = Input.GetAxis("Right Joystick Y");

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

        GetComponent<Rigidbody>().velocity = new Vector3(xfire, yfire, 0);
    }
}
