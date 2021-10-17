 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cam_page : MonoBehaviour 
{


	public GameObject vehiclelink;		
	Vector3 camOldPos;
	public Vector3 camMoved;



	void Update() 
	{
	

		Camera.main.orthographicSize -= Input.mouseScrollDelta.y * 0.7f;

		camOldPos = transform.position;
		
		transform.position = new Vector3 (vehiclelink.transform.position.x, vehiclelink.transform.position.y, -10.0f);

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
