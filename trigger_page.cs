using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_page : MonoBehaviour 
{


	public bool vehicleHasTraction;




	void OnTriggerStay2D()
	{
		vehicleHasTraction = true;
	}


	void OnTriggerExit2D()
	{
		vehicleHasTraction = false;
	}



}
