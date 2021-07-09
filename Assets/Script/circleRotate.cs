using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleRotate : MonoBehaviour
{
   public GameObject target;
   private void Start() {
       target = GameObject.Find("Center");
   }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.forward, Random.Range(20,50) * Time.deltaTime);
    }
}
