using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greyline_page : MonoBehaviour {


	public LineRenderer glr;

	Vector2 greystartcoords;
	Vector2 currentcoords;
	bool greylineinprogress;



	void Start () 
	{
		greylineinprogress = false;
	}



	void Update () 
	{



		if (Input.GetMouseButtonDown(0))
		{
			greystartcoords = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			greylineinprogress = true;
		}


		if (greylineinprogress)
		{
			currentcoords = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			glr.positionCount = 2;
			glr.SetPosition (0, greystartcoords);
			glr.SetPosition (1, currentcoords);

		}


		if (Input.GetMouseButtonDown(1) && greylineinprogress)
		{
			greylineinprogress = false;
			glr.positionCount = 0;
		}



	}
}
