using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_page : MonoBehaviour
{
        
    cam2_page cam2pageLink;        
    
    public int resetStatus = 0;    
    float timeStamp = 0f;


    void Start () {        
        cam2pageLink = GameObject.Find("Camera2").GetComponent<cam2_page>();        
    }


    void Update()
    {

        // quit game when keyboard press escape
        if (Input.GetKeyDown(KeyCode.Escape)) {
            print("end");
            Application.Quit();
        }      

        // when cam2 goes out of bounds, a cart reset sequence is triggered
        if (resetStatus == 0 && cam2pageLink.outOfBounds) {                        
            resetStatus = 1;
            timeStamp = Time.time;            
        }

        // wait 3 seconds before doing the cart reset, during which time, cam1 doesnt follow the cart
        if (resetStatus == 1 && Time.time > timeStamp + 3f) {            
            resetStatus = 2;            
        }

        // prevents multiple sequential cart resets
        if (resetStatus == 2 && !cam2pageLink.outOfBounds) {            
            resetStatus = 0;
        }

    }

}

