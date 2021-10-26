using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// the trigger is an invisible trigger gameobject attached to the cart
// the cart can only move when the trigger is in contact with another object

public class trigger_page : MonoBehaviour 
{

	public bool vehicleHasTraction;


	void OnTriggerStay2D()
	{
		vehicleHasTraction = true;			//vehicle is in contact with another object
	}


	void OnTriggerExit2D()
	{
		vehicleHasTraction = false;
	}

}
