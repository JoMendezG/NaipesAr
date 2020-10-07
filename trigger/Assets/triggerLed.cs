using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerLed : MonoBehaviour
{
public Light luzLed;

    void Start()
    {
         luzLed.enabled = false;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Bateria9V")) {
            luzLed.enabled = true;  
        } else {
            luzLed.enabled = false;
        }
        
    }

    private void OnTriggerExit(Collider other) {
        luzLed.enabled = false;
    }

}