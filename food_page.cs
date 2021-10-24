using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food_page : MonoBehaviour
{
    
    Rigidbody2D rb;


    void Start()
    {
        transform.SetParent(GameObject.Find("foodParent").transform);
        rb = GetComponent<Rigidbody2D>();        
    }

    
    void FixedUpdate()
    {        
        Vector3 myvec = new Vector3(0f, 0f, 2f);
        rb.MoveRotation( transform.rotation * Quaternion.Euler(myvec));
    }

		
    void OnTriggerEnter2D (Collider2D incoming)    
	{        
        if (incoming.gameObject.name == "Vehicle") {            
            Destroy(gameObject);
        }        
	}

}
