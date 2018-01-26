using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class CollisionAvoidance : SteeringBehaviour
    {
        [SerializeField]
        Rigidbody2D thisRigidbody;
        public GameObject Placeholder;
        public GameObject[] walls;
        // Use this for initialization
        void Start()
        {
        thisRigidbody = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public override Vector3 UpdateBehaviour(SteeringAgent steeringAgent)
        {

            float avoidForce = 2f;
            Vector3 avoidVelocity = new Vector3(0, 0,0);
            float forward = thisRigidbody.velocity.magnitude / steeringAgent.maxSpeed;                          //gets the length of the collision detection
       
            Vector3 nextPosition = new Vector3(thisRigidbody.transform.position.x, thisRigidbody.transform.position.y ,0) + steeringAgent.currentVelocity * forward;        //vector for detecting collisions

            GameObject wall = NearestWall();

            if (wall != Placeholder)   //calculates the steering velocity  if there is a wall in range
            {
                avoidVelocity.x = nextPosition.x - wall.transform.position.x;
                avoidVelocity.y = nextPosition.y - wall.transform.position.y;
                avoidVelocity.Normalize();
                avoidVelocity += (avoidVelocity * avoidForce);
            }
            //Debug.Log(avoidVelocity);
            return steeringVelocity += avoidVelocity;
        }

        GameObject NearestWall()
        {
            GameObject nearest = Placeholder;
            SteeringAgent steeringAgent;
            steeringAgent = this.GetComponent<SteeringAgent>();
        // sets the max velocity
            float forward = thisRigidbody.velocity.magnitude / steeringAgent.maxSpeed ;                          //gets the length of the collision detection
            Vector2 nextPosition = new Vector2(thisRigidbody.transform.position.x, thisRigidbody.transform.position.y) + thisRigidbody.velocity.normalized * forward;        //vector for detecting collisions

            for (int i = 0; i < walls.Length; i++)         //finds the nearest wall to prioritise for collision avoidance
            {
                GameObject current = walls[i];
                bool willCollide = CollisionImminent(nextPosition, current);
                // Debug.Log(willCollide);
                if (willCollide == true && nearest == Placeholder)  //if the method is just starting, this stops it from never returning the nearest wall
                {
                    nearest = current;
                }
                if (willCollide == true && Vector3.Distance(current.transform.position, this.transform.position) < Vector3.Distance(nearest.transform.position, this.transform.position))
                {
                    nearest = current;

                }
            }

            return nearest;     //returs the nearest wall
        }



        bool CollisionImminent(Vector2 predictedVelocity, GameObject wall)         //checks if the enemy will collide with a wall
        {
            float radius = 1;
            return (Vector3.Distance(wall.transform.position, predictedVelocity) <= radius);
        }
    }

