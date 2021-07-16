using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject planetPre;
    public GameObject blackHolePre;
    RaycastHit mraycastHit;
    private void Update() {

        // Left click to instatiate a new planet or choose the planet
        if(Input.GetButtonDown("Fire1")){

            if(getMousePositionRayHit()){

                if(mraycastHit.transform.gameObject.tag == "planet"){
                    Debug.Log("hit planet");
                    var tempRender = mraycastHit.transform.GetComponent<Renderer>();
                    tempRender.material.SetColor("_Color",Color.green);

                }else{
                    Debug.Log("Raycast hit");
                    Vector3 newPlanetPosi =  mraycastHit.point;
                    newPlanetPosi.z = 0;
                    Instantiate(planetPre,newPlanetPosi,Quaternion.identity);
                }
            }
            
        }

        if(Input.GetButtonDown("Fire2")){
            if(getMousePositionRayHit()){
                Vector3 newBlackHolePosi = mraycastHit.point;
                newBlackHolePosi.z = 0;
                Instantiate(blackHolePre, newBlackHolePosi,Quaternion.identity);
            }

        }
    }

    bool getMousePositionRayHit(){
        Vector3 mousePosi = Input.mousePosition;
        // Debug.Log(mousePosi);
        Ray rayNewPosi = Camera.main.ScreenPointToRay (mousePosi);
        if(Physics.Raycast(rayNewPosi, out RaycastHit raycastHit)){
            mraycastHit = raycastHit;
            return true;
        }else{
            return false;
        }
    }
}
