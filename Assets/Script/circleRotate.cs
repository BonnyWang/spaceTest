using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleRotate : MonoBehaviour
{
    public float initialVelocity;
    float scaleSize;
    [SerializeField] private int rotateSpeed;

    private GameObject target;
    private void Start() {
        target = GameObject.Find("Center");
        GetComponent<Rigidbody>().velocity = new Vector3(initialVelocity,initialVelocity,initialVelocity);

        scaleSize = Random.Range(0.2f,1);
        rotateSpeed = Random.Range(10,200);
        transform.localScale = new Vector3(scaleSize,scaleSize,scaleSize);
    }

        // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.forward,  rotateSpeed* Time.deltaTime);
    }
}
