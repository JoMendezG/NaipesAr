using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class led_batery_state : MonoBehaviour
{
    public bool quemar;


    void Start()
    {
        quemar = false;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bateria9VPositiva"))
        {
            quemar = true;
            print("Bateria positivo y led conectados ");

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Bateria9VPositiva"))
        {
            quemar = false;
            print("Bateria positivo y led conectados ");

        }
    }

}
