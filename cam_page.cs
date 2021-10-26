 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cam_page : MonoBehaviour 
{

	public GameObject vehiclelink;		
	Vector3 camOldPos;
	public Vector3 camMoved;
	float zoomVal;

	cam2_page cam2pageLink;

	

	void Start () {		
		zoomVal = 0.3f;
		cam2pageLink = GameObject.Find("Camera2").GetComponent<cam2_page>();
	}
	


	void Update() 
	{	

		// zoom with scroll wheel
		zoomVal -= Input.mouseScrollDelta.y * 0.05f;
		zoomVal = Mathf.Clamp01(zoomVal);
		Camera.main.orthographicSize = Mathf.Lerp(3f, 45f, zoomVal);		

		camOldPos = transform.position;		

		if (!cam2pageLink.outOfBounds) {
			// camera follows vehicle		
			transform.position = new Vector3 (vehiclelink.transform.position.x, vehiclelink.transform.position.y, -10.0f);			
		}

		camMoved = transform.position - camOldPos;

			// Mathf.Lerp(
			// 	Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
			// 	vehiclelink.transform.position.x,
			// 	0.9f
			// ),

			// Mathf.Lerp(
			// 	Camera.main.ScreenToWorldPoint(Input.mousePosition).y,
			// 	vehiclelink.transform.position.y,
			// 	0.9f
			// ),			
	}

}
