using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionScript: MonoBehaviour {
    public Follow follow;
    public GameObject Player1;
    public GameObject Player2;

    public GameObject enemy;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Enemies":
             if (this.gameObject.tag == "Bullet")
                {
                    //enemy.GetComponent<SpriteRenderer>().color = new Color(244, 66, 212, 255);
                    follow = other.gameObject.GetComponent<Follow>();
                    if (follow.Player1sBitch == false)
                    {
                        other.gameObject.GetComponent<Follow>();
                        Destroy(this.gameObject);
                        follow.Player1sBitch = true;
                        follow.Player2sBitch = false;
                        other.tag = "Player1sBitch";
                       
                    }
                }

             if( this.gameObject.tag == "Bullet2")
                {
                    //enemy.GetComponent<SpriteRenderer>().color = new Color(62, 242, 80, 255);
                    follow = other.gameObject.GetComponent<Follow>();
                    if (follow.Player2sBitch == false)
                    {
                        Destroy(this.gameObject);
                        follow.Player2sBitch = true;
                        follow.Player1sBitch = false;
                        other.tag = "Player2sBitch";
                        
                    }
                }

                break;

            case "Player1sBitch":
                if (this.gameObject.tag == "Bullet2")
                {
                    follow = other.gameObject.GetComponent<Follow>();
                    if (follow.Player2sBitch == false)
                    {
                        Destroy(this.gameObject);
                        follow.Player2sBitch = true;
                        follow.Player1sBitch = false;
                        other.tag = "Player2sBitch";
                    }
                }
                break;
            case "Player2sBitch":
                follow = other.gameObject.GetComponent<Follow>();
                if (follow.Player1sBitch == false)
                {
                    other.gameObject.GetComponent<Follow>();
                    Destroy(this.gameObject);
                    follow.Player1sBitch = true;
                    follow.Player2sBitch = false;
                    other.tag = "Player1sBitch";
                }
                break;
        }

        ////Projectile change alliance
        //if (this.gameObject.tag == "Bullet2" && other.gameObject.tag == "Enemies" || other.gameObject.tag == "Player1sBitch")
        //{
        //    follow = other.gameObject.GetComponent<Follow>();
        //     if (follow.Player2sBitch == false)
        //    {
        //        // Destroy(other.gameObject);
        //        follow.Player2sBitch = true;
        //        follow.Player1sBitch = false;
        //        other.tag = "Player2sBitch";
        //    }

        //}

        ////Projectile change alliance
        //if (this.gameObject.tag == "Bullet" && other.gameObject.tag == "Enemies"|| other.gameObject.tag == "Player2sbitch")
        //{
        //    follow = other.gameObject.GetComponent<Follow>();
        //    if (follow.Player1sBitch == false)
        //    {
        //        other.gameObject.GetComponent<Follow>();
        //        //Destroy(other.gameObject);
        //        follow.Player1sBitch = true;
        //        follow.Player2sBitch = false;
        //        other.tag = "Player1sBitch";
        //    }

        //}

       
    }
}
