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
        // food is constantly rotating
        rb.MoveRotation(transform.rotation * Quaternion.Euler(new Vector3(0f, 0f, 2f)));
    }

		
    void OnTriggerEnter2D (Collider2D incoming)    
	{
      
        // destory any food that is inside a block
        if (incoming.gameObject.tag == "block") {            
            Destroy(gameObject);
        }

        // destory food when collected by player
        if (incoming.gameObject.name == "Cart") {            
            Destroy(gameObject);
        }
	}

}
