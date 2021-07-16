using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disAppear : MonoBehaviour
{
    // Start is called before the first frame update
     void Start()
    {
       StartCoroutine(removeMe());
    }

    IEnumerator removeMe(){
        yield return new WaitForSeconds(2);
        gravitationalF.Bodies.Remove(GetComponent<gravitationalF>());
        Destroy(gameObject);
    }

}
