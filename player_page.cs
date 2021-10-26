using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_page : MonoBehaviour {



	public float thrustForce;
	bool thrusting;
	int flipped = 1;

	Rigidbody2D rb;
	public trigger_page pageLink;


	public GameObject triangle1Link;
	public GameObject triangle2Link;




	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}




	void Update () 
	{

		if (Input.GetKey("right") || Input.GetKey("d")) {
			thrusting = true;
			if (transform.eulerAngles.z < 180f) {			//check if cart is upside down
				positiveThrust();
			} else {
				negativeThrust();
			}
		}

		if (Input.GetKey("left") || Input.GetKey("a")) {
			thrusting = true;
			if (transform.eulerAngles.z > 180f) {			//check if cart is upside down
				positiveThrust();
			} else {
				negativeThrust();
			}
		}

		void positiveThrust () {							//go forwards
			flipped = 1;
			triangle1Link.SetActive(true);
			triangle2Link.SetActive(false);			
		}

		void negativeThrust () {							//go backwards
			flipped = -1;
			triangle1Link.SetActive(false);
			triangle2Link.SetActive(true);				
		}

		if (!pageLink.vehicleHasTraction) {thrusting = false;}

	}




	void FixedUpdate ()
	{
		
		if (thrusting) {
			rb.AddForce (-transform.up * thrustForce * flipped);
			thrusting = false;
		}

	}


}
