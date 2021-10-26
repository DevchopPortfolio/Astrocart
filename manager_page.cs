using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_page : MonoBehaviour
{
    

    cam2_page cam2pageLink;
    float countDownToQuit = 0f;


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


        // quit game 3 seconds after camera goes out-of-bounds
        if (cam2pageLink.outOfBounds) {
            
            if (countDownToQuit == 0f) {countDownToQuit = Time.time;}

            if (Time.time > countDownToQuit + 3f) {
                print("end");
                Application.Quit();                
            }
            
        }

    }

}

