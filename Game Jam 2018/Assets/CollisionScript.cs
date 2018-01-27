using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {
    public LifeScript playerLifeScript;
    public LifeScript playerLifeScript2;
    bool auraBuffP1 = false;
    bool auraBuffP2 = false;
    public float auraBuffTimerP1 = 10;
    public float auraBuffTimerP2 = 10;

    public Follow follow;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        auraBuffTimerP1 -= Time.deltaTime;
        auraBuffTimerP2 -= Time.deltaTime;

    }
    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player1sBitch":
                if (this.tag == "Player2")
                {
                    if (auraBuffP2 == true)
                    {
                        
                        follow.Player2sBitch = true;
                        follow.Player1sBitch = false;
                    }
                    else
                    {
                        playerLifeScript.player2Health -= 1;
                    }
                }
                break;
            case "Player2sBitch":
                if (auraBuffP1 == true)
                {
                    
                    follow.Player1sBitch = true;
                    follow.Player2sBitch = false;
                }
                else
                {
                    playerLifeScript2.player1Health -= 1;
                }
                break;
            case "AuraBuff":
                if (this.tag == "Player1")
                {
                    auraBuffP1 = true;
                    auraBuffTimerP1 = 10;
                }
                else if(this.tag == "Player2")
                {
                    auraBuffP2 = true;
                    auraBuffTimerP2 = 10;
                }
                break;
                
        }


   
        //if (this.tag == "Player2" && collision.gameObject.tag == "Player1sBitch")
        //{
        //    playerLifeScript.player2Health -= 1;
        //}

        //if (this.tag == "Player1" && collision.gameObject.tag == "Player2sBitch")
        //{
        //    playerLifeScript2.player1Health -= 1;
        //}
        
    }
}
