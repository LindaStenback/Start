using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {
    public LifeScript playerLifeScript;
    public LifeScript playerLifeScript2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        if (this.tag == "Player1sBitch" && collision.gameObject.tag == "Player2")
        {
            playerLifeScript.player2Health -= 1;
        }

        if (this.tag == "Player2sBitch" && collision.gameObject.tag == "Player1")
        {
            playerLifeScript2.player1Health -= 1;
        }
    }
}
