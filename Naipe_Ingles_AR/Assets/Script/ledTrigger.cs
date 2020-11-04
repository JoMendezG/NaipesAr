using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;



public class ledTrigger : MonoBehaviour {
    

    public Light luzLed;

    void Start() {
        luzLed.enabled = false; 
        

    }

    void OnTriggerEnter(Collider other) {
      if (other.gameObject.CompareTag("Bateria9V")) {
            luzLed.intensity = 8;
            luzLed.enabled = true;  
        } else {
            luzLed.enabled = false;
        }
    }

    void OnTriggerExit(Collider other) {
        luzLed.enabled = false; 
    }


}
