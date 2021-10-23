using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line_page : MonoBehaviour 
{

	LineRenderer lr; 		
	List<Vector2> myList = new List<Vector2> ();


	void Awake () {
		lr = GetComponent<LineRenderer> ();
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

}
