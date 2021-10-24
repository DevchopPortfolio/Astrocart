using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineDraw_page : MonoBehaviour 
{

	public GameObject linePrefabLink;
	public GameObject linesContainerLink;
	public bool lineinprogress;

	public GameObject linkToVehicle;

	GameObject lineLink;
	line_page linepageLink;





	void Start () 
	{
		lineinprogress = false;			
	}




	void Update ()
	{

		
		if (Input.GetMouseButtonDown(0)) 
		{
			
			if (lineinprogress == false) 
			{
				lineLink = Instantiate(linePrefabLink);
				lineLink.transform.SetParent(linesContainerLink.transform);

				linepageLink = lineLink.GetComponent<line_page>();
			}

			lineinprogress = true;
			linepageLink.updateLine (Camera.main.ScreenToWorldPoint(Input.mousePosition));

		}


		if (Input.GetMouseButtonDown(1)) 
		{
			lineinprogress = false;
			linepageLink.lineDying = true;
		}


	}

}