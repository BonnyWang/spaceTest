using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createDisaster : MonoBehaviour
{
    public GameObject planetPre;
    float posX;
    float posY;
    Vector3 instatiatePosi;

    float currentTime;

    
    void Start()
    {
        currentTime = Time.time;

        // for (int i = 0; i < 10; i++){
        //     posX = Random.Range(2,10);
        //     posY = Random.Range(0.5f,2);     

        //     instatiatePosi = new Vector3(posX,posY,0);

        //     Instantiate(planetPre,instatiatePosi,Quaternion.identity);  
        // }
        
    }

    // Update is called once per frame
    void Update()
    {
        if((Time.time - currentTime) > 1f){
            currentTime = Time.time;
            
            posX = Random.Range(-5,5);
            posY = Random.Range(-5,5);     

            instatiatePosi = new Vector3(posX,posY,0);

            Instantiate(planetPre,instatiatePosi,Quaternion.identity);
        }
        
    }
}
