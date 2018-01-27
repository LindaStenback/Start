using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastAvoidance : SteeringBehaviour {
    
   
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
	}
   
    public override Vector3 UpdateBehaviour(SteeringAgent steeringAgent)
    {


        float vision = 3f;
        Vector3 leftRay = transform.position;
        Vector3 rightRay = transform.position;
        Vector3 direction = Vector3.zero;
        RaycastHit hit;



        if (Physics.Raycast(transform.position, transform.up, out hit, vision))
        {
            Debug.DrawRay(transform.position, hit.point);

            if (steeringAgent.hit.transform != transform && hit.collider.tag == "Collision")
            {
                Debug.Log("Working");
                direction += (transform.position - steeringAgent.hit.normal) * steeringAgent.maxSpeed;
   

                desiredVelocity = direction * steeringAgent.maxSpeed;
                steeringVelocity = (desiredVelocity - steeringAgent.currentVelocity) * steeringAgent.collisionWeight;
            }


        }
        else
        {
            steeringVelocity = Vector3.zero;
            return steeringVelocity;
        }

          



        return steeringVelocity;
       
    }

    
}
