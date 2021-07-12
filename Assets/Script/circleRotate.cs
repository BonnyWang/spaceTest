using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleRotate : MonoBehaviour
{
    public GameObject target;
    [SerializeField] private int rotateSpeed;
    float scaleSize;
    private void Start() {
        target = GameObject.Find("Center");

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
