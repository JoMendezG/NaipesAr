using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class jumper_jumper_battery_state : MonoBehaviour
{

    public bool jumper_positivo, jumper_negativo, jumper_jumper;
    public GameObject jumper; //Ingresar el objeto a reconocer


    void Start()
    {
        jumper_positivo = false;
        jumper_negativo = false;
        jumper_jumper = true;

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bateria9VNegativa"))
        {
            jumper_negativo = true;
            print("Bateria negativo conectada");

        }
        if (other.gameObject.CompareTag("Bateria9VPositiva"))
        {
            jumper_positivo = true;
            print("Bateria positivo conectada");

        }

        if (other.gameObject.CompareTag("jumper"))
        {
            jumper_jumper = true;

            //si el otro jumper está conectado a la batería, que el estado de bateria_negativo pase a ser true.
            //nombre del script. nuevo nombre = objeto a reconocer.GetComponent<nombre del script>....
            jumper_jumper_battery_state jumper_anterior = jumper.GetComponent<jumper_jumper_battery_state>();
            //Tipo de variable a buscar nuevo nombre = nombre declarado recién.nombre de la variable a buscar
            jumper_negativo = jumper_anterior.jumper_negativo;
            jumper_positivo = jumper_anterior.jumper_positivo;

            print("jumper conectado a jumper");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Bateria9VNegativa"))
        {
            jumper_negativo = false;
            print("Bateria negativo desconectada");
        }
        if (other.gameObject.CompareTag("Bateria9VPositiva"))
        {
            jumper_positivo = false;
            print("Bateria positivo desconectada");

        }
        if (other.gameObject.CompareTag("jumper"))
        {
            jumper_jumper = false;
            jumper_negativo = false;
            print("jumper desconectado de jumper");
        }
    }

}