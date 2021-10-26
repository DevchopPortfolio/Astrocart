using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineDraw_page : MonoBehaviour 
{

	public GameObject linePrefabLink;
	public GameObject linesContainerLink;
	public bool lineinprogress = false;

	public GameObject cartGOLink;

	GameObject lineLink;
	line_page linepageLink;



	void Update ()
	{
		
		// left click starts a line
		if (Input.GetMouseButtonDown(0)) 
		{
			
			// new line gameObject line if not already drawing
			if (lineinprogress == false) 
			{
				lineLink = Instantiate(linePrefabLink);
				lineLink.transform.SetParent(linesContainerLink.transform);

				linepageLink = lineLink.GetComponent<line_page>();
			}
			
			lineinprogress = true;
			
			// assign mouse coords to new line
			linepageLink.updateLine (Camera.main.ScreenToWorldPoint(Input.mousePosition));
		}


		// right click terminates the current line
		if (Input.GetMouseButtonDown(1)) 
		{
			lineinprogress = false;
			linepageLink.lineDying = true;
		}

	}

}