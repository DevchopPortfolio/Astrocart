using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greyline_page : MonoBehaviour {


	LineRenderer lr;

	Vector2 greystartcoords;
	Vector2 currentcoords;
	bool greylineinprogress;



	void Start () 
	{
		lr = GetComponent<LineRenderer>();
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

			lr.positionCount = 2;
			lr.SetPosition (0, greystartcoords);
			lr.SetPosition (1, currentcoords);

		}


		if (Input.GetMouseButtonDown(1) && greylineinprogress)
		{
			greylineinprogress = false;
			lr.positionCount = 0;
		}



	}
}
