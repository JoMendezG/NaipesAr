using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class led_resistence_state : MonoBehaviour
{

    public bool resistencia;

    void Start()
    {
        resistencia = false;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("resistencia"))
        {
            resistencia = true;
            print("resistencia conectada");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("resistencia"))
        {
            resistencia = false;
            print("resistencia desconectada");
        }

    }

}