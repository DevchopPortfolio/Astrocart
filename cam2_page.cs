using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam2_page : MonoBehaviour
{
               
    cam_page campageLink;
    public float ParallaxSpeed;
    public bool outOfBounds = false;


    void Start () {                
        campageLink = FindObjectOfType<cam_page>();        
    }


    void Update() {        

        outOfBounds = false;
        
        // check if cam2 is out-of-bounds
        if ((transform.position.y < 1984) || 
            (transform.position.y > 2008) || 
            (transform.position.x < 1981) || 
            (transform.position.x > 2019)) 
        {
                outOfBounds = true;
        }

        if (!outOfBounds) {
            // cam2 matches cam1 movements, but slower
            transform.position += campageLink.camMoved * ParallaxSpeed;
        }

    }

}
