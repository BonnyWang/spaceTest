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
        float inputValue = Input.GetAxis("Horizontal");
        if(Mathf.Abs(inputValue) >0){
           
            transform.RotateAround(earth.transform.position, Vector3.back, inputValue);
            
        }
    }
}
