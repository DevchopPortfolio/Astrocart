using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam2_page : MonoBehaviour
{
    
           
    cam_page campageLink;
    public float ParallaxSpeed;



    void Start () {                

        campageLink = FindObjectOfType<cam_page>();
       
    }



    void Update() {        

        transform.position += campageLink.camMoved * ParallaxSpeed;
        
    }

}
