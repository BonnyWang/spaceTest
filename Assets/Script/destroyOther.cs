using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOther : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag == "planet"){
            Destroy(other.gameObject);
        }
    }
}
