﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript1 : MonoBehaviour {
    public Follow follow;
   

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //Projectile change alliance
        if (other.gameObject.tag == "Enemies"|| other.gameObject.tag == "Player2sbitch")
        {
            follow = other.gameObject.GetComponent<Follow>();
            if (follow.Player1sBitch == false)
            {
                other.gameObject.GetComponent<Follow>();
                Destroy(other.gameObject);
                follow.Player1sBitch = true;
                follow.Player2sBitch = false;
                other.tag = "Player1sBitch";
            }

        }

        //Projectile change alliance
        if (other.gameObject.tag == "Enemies" || other.gameObject.tag == "Player1sBitch")
        {
            follow = other.gameObject.GetComponent<Follow>();
            if (follow.Player2sBitch == false)
            {
                Destroy(other.gameObject);
                follow.Player2sBitch = true;
                follow.Player1sBitch = false;
                other.tag = "Player2sBitch";
            }

        }
    }
}
