using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resistenciaTrigger : MonoBehaviour
{

    public bool encenderLed;

    void Start()
    {
       encenderLed = false; 
    }

    void OnTriggerEnter(Collider other) {
      if (other.gameObject.CompareTag("Resistencia220")) {
            encenderLed = true; 
        } else {
            encenderLed = false;  
        }
    }

    void OnTriggerExit(Collider other) {
        encenderLed = false; 
    }



}
