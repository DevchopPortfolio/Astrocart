using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line_page : MonoBehaviour 
{


	LineRenderer lr; 		

	List<Vector2> myList = new List<Vector2> ();





	public void updateLine (Vector2 thesecoords)
	{

		lr = GetComponent<LineRenderer> ();
		lr.positionCount += 1;
		lr.SetPosition(lr.positionCount - 1, thesecoords);

		myList.Add(thesecoords);

		if (myList.Count > 1) { GetComponent<EdgeCollider2D>().points = myList.ToArray(); }

	}




}
