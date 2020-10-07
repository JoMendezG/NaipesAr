using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;



public class ledTrigger : MonoBehaviour {
    

    public Light luzLed;

    void Start() {
        luzLed.enabled = false; 
        Debug.Log("Inicio Código");

    }

    void OnTriggerEnter(Collider other) {
      if (other.gameObject.CompareTag("Bateria9V")) {
            luzLed.enabled = true;  
        } else {
            luzLed.enabled = false;
        }
    }

    void OnTriggerExit(Collider other) {
        Debug.Log("Trigger desactivado");
        luzLed.enabled = false; 
    }


}
