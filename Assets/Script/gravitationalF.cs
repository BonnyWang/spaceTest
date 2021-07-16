using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravitationalF : MonoBehaviour
{
    // temporaral to test two object system
    public GameObject otherObj;
    const float gConst = 600;
    public static List<gravitationalF> Bodies;
    public Rigidbody rb { get; protected set; }


    double gForce;

    void Start()
    {

        rb = GetComponent<Rigidbody>();

        if (Bodies == null){
			Bodies = new List<gravitationalF>();
            Bodies.Add(this);
        }else{
            Bodies.Add(this);
        }
    }

    // Update is called once per frame
    private void FixedUpdate() {
        
        foreach( gravitationalF body in Bodies){
            if(body == this){
                continue;
            }


            // Calculate the distance between the two body
            float r = Vector3.Distance (transform.position, body.transform.position);

            float gForceMag = gConst*( rb.mass* body.rb.mass) / Mathf.Pow (r, 2);

            Vector3 forceDirection = Vector3.Normalize (body.transform.position - transform.position);

            Vector3 gForce = (forceDirection*gForceMag)* Time.fixedDeltaTime;

            rb.AddForce(gForce);
        }
    }
}
