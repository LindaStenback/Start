using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour {
    //SpriteRender render;
	// Use this for initialization
	void Start () {
        //render = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Bullet") {
        //    print("test1");
        //    GetComponent<SpriteRenderer>().color = new Color(244, 66, 212, 255);
        //}
        //if (other.gameObject.tag == "Bullet2")
        //{
        //    print("test2");
            
        //    render.material.color = new Color(62, 242, 80, 255);
        //}
    }
   }
