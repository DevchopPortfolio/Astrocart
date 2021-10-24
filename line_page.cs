using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line_page : MonoBehaviour 
{

	public bool lineDying;
	int lineLifespan;

	int thisLineAge;

	

	LineRenderer lr; 		
	List<Vector2> myList = new List<Vector2> ();




	void Awake () {
		transform.SetParent(GameObject.Find("linesParent").transform);
		lr = GetComponent<LineRenderer> ();
		thisLineAge = 0;
		lineLifespan = 3000;
	}


	public void updateLine (Vector2 newCoords)
	{		

		// add line to LineRenderer component
		lr.positionCount += 1;
		lr.SetPosition(lr.positionCount - 1, newCoords);

		// add line to EdgeCollider component
		myList.Add(newCoords);		
		if (myList.Count > 1) { GetComponent<EdgeCollider2D>().points = myList.ToArray(); }

	}


	void Update () {

		if (lineDying) {
			thisLineAge++;
			float lifespanAsDecimal = (float)thisLineAge / (float)lineLifespan;
			lr.material.color = Color.Lerp(Color.white, new Color(1f,1f,1f,0.05f), lifespanAsDecimal);			
		}		 

		if (thisLineAge > lineLifespan) {
			Destroy(gameObject);
		}

	}




}
