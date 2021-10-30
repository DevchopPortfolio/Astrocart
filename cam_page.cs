 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cam_page : MonoBehaviour 
{

	GameObject cartLink;			
	manager_page managerpageLink;

	Vector3 camOldPos;
	public Vector3 camMoved;
	float zoomVal = 0.3f;



	void Start () {				
		cartLink = GameObject.Find("Cart");		
		managerpageLink = GameObject.Find("page holder").GetComponent<manager_page>();      
	}
	


	void Update()
	{	

		// zoom with scroll wheel
		zoomVal -= Input.mouseScrollDelta.y * 0.05f;
		zoomVal = Mathf.Clamp01(zoomVal);
		Camera.main.orthographicSize = Mathf.Lerp(3f, 45f, zoomVal);		

		camOldPos = transform.position;		

		if (managerpageLink.resetStatus != 1) {		//cam doesnt follow when cart is out of bounds
			// camera follows cart
			transform.position = new Vector3 (cartLink.transform.position.x, cartLink.transform.position.y, -10.0f);
		}

		camMoved = transform.position - camOldPos;
		
	}

}
