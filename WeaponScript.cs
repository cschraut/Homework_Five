using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float shootRange = 15f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }
    private void Shoot(){
        RaycastHit hit;

        if(Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, shootRange)){
            //do something
            Debug.Log("I hit an object");
        }
        else{
            return;
        }
        
        
    }
}
