using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : SteeringBehaviour {
    public float waitTimer;
   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        waitTimer -= Time.deltaTime;
	}

    
    public float circleRadius = 300f;
    
   public float circleDistance = .5f;

    public override Vector3 UpdateBehaviour(SteeringAgent steeringAgent)
    {
        Vector3 targetPosition;
        Vector3 leftRay = transform.position;
        Vector3 rightRay = transform.position;
        Vector3 direction = Vector3.zero;

        if (waitTimer < 0)
       {
            Vector3 point = Random.insideUnitCircle * circleRadius;
            point += transform.position += new Vector3((transform.up.x * circleDistance), (transform.up.y * circleDistance), (0)) ;
            
            targetPosition = point ;



            desiredVelocity = Vector3.Normalize(targetPosition - transform.position) * steeringAgent.maxSpeed;


            waitTimer = 3;
            
        }

        

        steeringVelocity = (desiredVelocity - steeringAgent.currentVelocity) * steeringAgent.wanderWeight;
       return steeringVelocity;
        
        
    }

}
