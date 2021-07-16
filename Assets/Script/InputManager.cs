using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject planetPre;
    private void Update() {
        if(Input.GetButtonDown("Fire1")){
            Vector3 mousePosi = Input.mousePosition;
            Debug.Log(mousePosi);
            Ray rayNewPosi = Camera.main.ScreenPointToRay (mousePosi);
            if(Physics.Raycast(rayNewPosi, out RaycastHit raycastHit)){

                if(raycastHit.transform.gameObject.tag == "planet"){
                    Debug.Log("hit planet");
                    var tempRender = raycastHit.transform.GetComponent<Renderer>();
                    tempRender.material.SetColor("_Color",Color.green);

                }else{
                    Debug.Log("Raycast hit");
                    Vector3 newPlanetPosi =  raycastHit.point;
                    newPlanetPosi.z = 0;
                    Instantiate(planetPre,newPlanetPosi,Quaternion.identity);
                }
            }
            
        }
    }
}
