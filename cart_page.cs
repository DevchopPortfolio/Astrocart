using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cart_page : MonoBehaviour {


	Rigidbody2D rb;
	public trigger_page pageLink;
	public GameObject triangle1Link;
	public GameObject triangle2Link;

	manager_page managerpageLink;

	Vector3 cartStartPos;
	float thrustForce = 12f;
	bool thrusting;
	int flipped = 1;



	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		cartStartPos = transform.position;		
		managerpageLink = GameObject.Find("page holder").GetComponent<manager_page>();
	}


	void Update () 
	{

		// keyboard input: press right
		if (Input.GetKey("right") || Input.GetKey("d")) {
			thrusting = true;
			if (transform.eulerAngles.z < 180f) {
				positiveThrust();
			} else {								//invert if cart is upside down
				negativeThrust();
			}
		}

		// keyboard input: press left
		if (Input.GetKey("left") || Input.GetKey("a")) {
			thrusting = true;
			if (transform.eulerAngles.z < 180f) {			
				negativeThrust();
			} else { 								//invert if cart is upside down
				positiveThrust();				
			}
		}

		//cart go forwards
		void positiveThrust () {							
			flipped = 1;
			triangle1Link.SetActive(true);
			triangle2Link.SetActive(false);			
		}

		//cart go backwards
		void negativeThrust () {							
			flipped = -1;
			triangle1Link.SetActive(false);
			triangle2Link.SetActive(true);				
		}

		// only move if cart has traction
		if (!pageLink.vehicleHasTraction) {thrusting = false;}

		
		// reset position when player presses T
		if (Input.GetKey("t")) {
			transform.position = cartStartPos;		
		}
		
		// reset cart position when manager requets a reset
		if (managerpageLink.resetStatus == 2) {
			transform.position = cartStartPos;			
		}

	}




	void FixedUpdate ()
	{

		// applies cart's movement to cart's position
		if (thrusting) {
			rb.AddForce (-transform.up * thrustForce * flipped);
			thrusting = false;			
		}
	}

}
