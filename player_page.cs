using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_page : MonoBehaviour {



	public float thrustForce;
	bool thrusting;
	int flipped = 1;

	Rigidbody2D rb;
	public trigger_page pageLink;		//this link is populated via dragNdrop - dragging in the gameobject that trigger_page is attached to


	public GameObject triangle1Link;
	public GameObject triangle2Link;




	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}




	void Update () 
	{
		
		if (Input.GetKey("right shift") && pageLink.vehicleHasTraction)
		{
			thrusting = true;
		}


		if (Input.GetButtonDown("Fire1")) 
		{
			flipped = -flipped;

			if (flipped == 1)
			{
				triangle1Link.SetActive (true);
				triangle2Link.SetActive (false);
			}
			else
			{
				triangle1Link.SetActive (false);
				triangle2Link.SetActive (true);
			}

		}

	}




	void FixedUpdate ()
	{
		
		if (thrusting) 
		{
			rb.AddForce (-transform.up * thrustForce * flipped);
			thrusting = false;
		}

	}


}
