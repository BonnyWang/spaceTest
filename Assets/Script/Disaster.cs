using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disaster : MonoBehaviour
{
    float scaleSize;

    GameObject earth;
    void Start()
    {
        scaleSize = Random.Range(0.1f,0.3f);

        transform.localScale = new Vector3(scaleSize,scaleSize,scaleSize);

        earth = GameObject.Find("Earth");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
