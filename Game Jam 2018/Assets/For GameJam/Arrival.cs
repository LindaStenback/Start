using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrival : SteeringBehaviour {

     public float arrivalRadius = 3f;

     public float deadZone = 2f;


    public override Vector3 UpdateBehaviour(SteeringAgent steeringAgent)
    {

        // Get the target position from the mouse input
        Vector3 targetPosition = steeringAgent.target.transform.position;
        Vector3 direction = targetPosition - transform.position;
        float distance = direction.magnitude;
        

        if (distance < deadZone)
        {
            distance = 0;

        }

        if (distance < arrivalRadius)
        {
            desiredVelocity = Vector3.Normalize(desiredVelocity) * (steeringAgent.maxSpeed * (distance / arrivalRadius));
        }
        else
        {
            desiredVelocity = Vector3.Normalize(targetPosition - transform.position) * steeringAgent.maxSpeed;
        }
        if (distance == 0)
        {
            steeringVelocity = Vector3.zero;
            steeringAgent.currentVelocity = Vector3.zero;
            return steeringVelocity;
        }

        steeringVelocity = (desiredVelocity - steeringAgent.currentVelocity) * steeringAgent.arrivalWeight;
        
          return steeringVelocity;
        




    }
}
