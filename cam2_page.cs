using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam2_page : MonoBehaviour
{
               
    cam_page campageLink;
    public float ParallaxSpeed;
    public bool outOfBounds;


    void Start () {                
        campageLink = FindObjectOfType<cam_page>();
        outOfBounds = false;
    }


    void Update() {        

        // transform.position = new Vector3 (
        //     Mathf.Clamp(transform.position.x, 1981f, 2019f),
        //     Mathf.Clamp(transform.position.y, 1984f, 2008f),
        //     transform.position.z
        // );

        outOfBounds = false;
        
        if ((transform.position.y < 1984) || 
            (transform.position.y > 2008) || 
            (transform.position.x < 1981) || 
            (transform.position.x > 2019)) 
        {
                outOfBounds = true;
        }

        if (!outOfBounds) {
            transform.position += campageLink.camMoved * ParallaxSpeed;
        }

    }

}
