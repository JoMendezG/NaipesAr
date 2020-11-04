using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BateriaYResistenciaLed : MonoBehaviour
{
    public Light luzLed;
    public bool res220;
    public bool bateria9V;

    void Start()
    {
        luzLed.enabled = false; 
        res220 = false;
        bateria9V = false;
    }

   void OnTriggerEnter(Collider other) {
      
        if (other.gameObject.CompareTag("Bateria9V")) {
            bateria9V = true;  
        } else {
            bateria9V = false;
        }
        
         if (other.gameObject.CompareTag("Resistencia220")){ 
            res220 = true;
        } else {
            res220 = false;
        }
        
         if (other.gameObject.CompareTag("Bateria9V") && other.gameObject.CompareTag("Resistencia220")) {
            bateria9V = true;
            res220 = true;
        } else {
            res220 = false;
            bateria9V = false;
        }


        if (bateria9V==true) {
            Debug.Log("Bateria es true");
            luzLed.intensity = 15;
            luzLed.enabled = true; 
        } else if (res220 == true){
            Debug.Log("Resistencia detectada");
            luzLed.enabled = false; 
        }else if (res220 == true && bateria9V == true) {
            Debug.Log("Res y Bateria son true");
            luzLed.intensity = 5;
            luzLed.enabled = true; 
        } else {
            Debug.Log("Todo es false");
            luzLed.enabled = false;
            luzLed.intensity = 1;
        }
    }

    void OnTriggerExit(Collider other) {
        luzLed.enabled = false; 
        res220 = false;
        bateria9V = false;
    }

}
