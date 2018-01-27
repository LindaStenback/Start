using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {
    public LifeScript player1LifeScript;
    public LifeScript player2LifeScript;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    if (this.tag == "Player1sBitch" && hit.gameObject.tag == "Player2")
    //    {
    //        player2LifeScript.player2Health -= 1;
    //    }

    //    if (this.tag == "Player2sBitch" && hit.gameObject.tag == "Player1")
    //    {
    //        player1LifeScript.player1Health -= 1;
    //    }
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.tag == "Player1sBitch" && collision.gameObject.tag == "Player2")
        {
            Debug.Log("Working");
            player2LifeScript.player2Health -= 1;
        }

        if (this.gameObject.tag == "Player2sBitch" && collision.gameObject.tag == "Player1")
        {
            Debug.Log("Collision Working");
            player1LifeScript.player1Health -= 1;
        }
    }

   
}
