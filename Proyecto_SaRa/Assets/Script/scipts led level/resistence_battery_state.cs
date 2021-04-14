using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class resistence_battery_state : MonoBehaviour
{

    public bool resistencia_positivo;
    public bool resistencia_negativo;

    void Start()
    {
        resistencia_positivo = false;
        resistencia_negativo = false;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bateria9VPositiva"))
        {
            resistencia_positivo = true;
            print("Bateria positivo conectada");
        }
        if (other.gameObject.CompareTag("Bateria9VNegativa"))
        {
            resistencia_negativo = true;
            print("Bateria positivo y resistencia conectados ");

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Bateria9VPositiva"))
        {
            resistencia_positivo = false;
            print("Bateria positivo desconectada");
        }
        if (other.gameObject.CompareTag("Bateria9VNegativa"))
        {
            resistencia_negativo = false;
            print("Bateria positivo y resistencia desconectados ");

        }
    }

}
