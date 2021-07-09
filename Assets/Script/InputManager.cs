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
                
                Debug.Log("Raycast hit");
                Vector3 newPlanetPosi =  raycastHit.point;
                Instantiate(planetPre,newPlanetPosi,Quaternion.identity);
            }
            
        }
    }
}
