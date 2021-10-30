using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam2_page : MonoBehaviour
{
               
    cam_page campageLink;        
    float ParallaxSpeed = 0.06f;        
    public bool outOfBounds;


    void Start () {                
        campageLink = FindObjectOfType<cam_page>();  
    }


    void Update() {        

        outOfBounds = false;
                
        // check if this cam is out-of-bounds
        if ((transform.position.y < 1984) || 
            (transform.position.y > 2008) || 
            (transform.position.x < 1981) || 
            (transform.position.x > 2019)) 
        {
                outOfBounds = true;    //this value is read by the manager page
        }
    
        transform.position = new Vector3 (
            transform.position.x + (campageLink.camMoved.x * ParallaxSpeed),
            transform.position.y + (campageLink.camMoved.y * ParallaxSpeed),
            transform.position.z
        );        

    }

}
