using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotController : MonoBehaviour
{
    GameObject earth;
    void Start()
    {
        earth = GameObject.Find("Earth");
    }

    // Update is called once per frame
    void Update()
    {   
        move();
    }

    void move(){
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        if(Mathf.Abs(inputH) >0){
           
            transform.RotateAround(earth.transform.position, Vector3.back, inputH);
            
        }

        if(Mathf.Abs(inputV) > 0){
            
        }
    }
}
