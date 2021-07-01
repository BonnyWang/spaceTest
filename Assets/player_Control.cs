using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Control : MonoBehaviour
{
    float inputV;
    float inputH;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputV = Input.GetAxis("Vertical");
        inputH = Input.GetAxis("Horizontal");

        if(Mathf.Abs(inputV) > 0){
            Vector3 temp = new Vector3(0f,0f,inputV*10);
            GetComponentInChildren<Rigidbody>().velocity = temp;
        }

        if(Mathf.Abs(inputH) > 0){
            Vector3 temp = new Vector3(inputH*10,0f, 0f);
            GetComponentInChildren<Rigidbody>().velocity = temp;
        }
        
    }
}
