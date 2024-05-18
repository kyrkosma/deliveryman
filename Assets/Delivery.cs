using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage;

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision happened");    
    }

    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Package" && !hasPackage){
            Debug.Log("Package picked up");
            hasPackage = true;
        } else if (other.tag == "Customer" && hasPackage){
            Debug.Log("Delivered to the Customer");
        }
    }

}
