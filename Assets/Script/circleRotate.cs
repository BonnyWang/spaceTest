using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleRotate : MonoBehaviour
{

    // ***This script now only give an initial velocity



    public float initialVelocity;

    int rotateSpeed;
    float scaleSize;


    private GameObject target;
    private void Start() {
        target = GameObject.Find("Center");
        
        // GetComponent<Rigidbody>().velocity = new Vector3(initialVelocity,initialVelocity,initialVelocity);


        scaleSize = Random.Range(0.1f,0.3f);
        rotateSpeed = Random.Range(10,200);
        transform.localScale = new Vector3(scaleSize,scaleSize,scaleSize);
        
        // Set the mass relate to the scale of the object
        GetComponent<Rigidbody>().mass = scaleSize;

    }

        // Update is called once per frame
    void Update()
    {
        
        transform.RotateAround(target.transform.position, Vector3.forward,  rotateSpeed* Time.deltaTime);
    }
}
