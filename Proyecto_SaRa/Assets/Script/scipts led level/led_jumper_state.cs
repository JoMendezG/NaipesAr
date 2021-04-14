using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class led_jumper_state : MonoBehaviour
{

    public bool led_jumper;

    void Start()
    {
        led_jumper = false;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("jumper"))
        {
            led_jumper = true;
            print("jumper conectado a led");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("jumper"))
        {
            led_jumper = false;
            print("jumper desconectado de led");
        }

    }

}