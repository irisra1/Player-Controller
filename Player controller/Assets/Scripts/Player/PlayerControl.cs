using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    //public varibles
    public float MoveSpeed = 5F;
    Rigidbody body;
    // Use this for initialization
    void Start ()
    {
        //get ridgid body 
        body = gameObject.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update ()
      
    {
        //reset velocity to zero
        body.velocity = Vector3.zero;
        
        if (Input.GetAxis("Horizontal") != 0)
        {
            body.velocity += Vector3.right * MoveSpeed * Input.GetAxis("Horizontal");
            print("horizontal input recived");
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            body.velocity += Vector3.forward * MoveSpeed * Input.GetAxis("Vertical");
            print("vertical input recived");
        }
        
	}
}
