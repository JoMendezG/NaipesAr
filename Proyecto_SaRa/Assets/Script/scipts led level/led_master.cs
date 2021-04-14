using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class led_master : MonoBehaviour
{

    public Light luzLed; // Luz a modificar

    public GameObject resistencia; //Ingresar el objeto a reconocer 

    public GameObject jumper; //Ingresar el objeto a reconocer 
    public GameObject jumper2; //Ingresar el objeto a reconocer 

    public GameObject led; //Ingresar el objeto a reconocer 

    public GameObject humo;


    void Start()
    {
        luzLed.intensity = 0.001f;
        humo.SetActive(false);

    }


    void Update()
    {
        //nombre del script. nuevo nombre = objeto a reconocer.GetComponent<nombre del script>....
        resistence_battery_state resistencia_bateria = resistencia.GetComponent<resistence_battery_state>();
        //Tipo de variable a buscar nuevo nombre = nombre declarado recién.nombre de la variable a buscar
        bool resistencia_positivo = resistencia_bateria.resistencia_positivo;
        bool resistencia_negativo = resistencia_bateria.resistencia_negativo;




        //nombre del script. nuevo nombre = objeto a reconocer.GetComponent<nombre del script>....
        jumper_jumper_battery_state jumper_bateria = jumper.GetComponent<jumper_jumper_battery_state>();
        jumper_jumper_battery_state jumper_bateria_2 = jumper2.GetComponent<jumper_jumper_battery_state>();
        //Tipo de variable a buscar nuevo nombre = nombre declarado recién.nombre de la variable a buscar
        bool jumper_negativo = jumper_bateria.jumper_negativo;
        bool jumper_negativo_2 = jumper_bateria_2.jumper_negativo;
        bool jumper_positivo = jumper_bateria.jumper_positivo;
        bool jumper_positivo_2 = jumper_bateria_2.jumper_positivo;
        bool jumper_jumper = jumper_bateria.jumper_jumper;

        if (jumper_negativo == true || jumper_negativo_2 == true)
        {
            jumper_negativo = true;
        }

        if (jumper_positivo == true || jumper_positivo_2 == true)
        {
            jumper_positivo = true;
        }



        //nombre del script. nuevo nombre = objeto a reconocer.GetComponent<nombre del script>....
        led_jumper_state led_jumper_conection = led.GetComponent<led_jumper_state>();
        //Tipo de variable a buscar nuevo nombre = nombre declarado recién.nombre de la variable a buscar
        bool led_jumper = led_jumper_conection.led_jumper;




        //nombre del script. nuevo nombre = objeto a reconocer.GetComponent<nombre del script>....
        led_resistence_state led_resistencia_conection = led.GetComponent<led_resistence_state>();
        //Tipo de variable a buscar nuevo nombre = nombre declarado recién.nombre de la variable a buscar
        bool led_resistencia = led_resistencia_conection.resistencia;

        led_batery_state led_Batery_conection = led.GetComponent<led_batery_state>();
        bool quemar = led_Batery_conection.quemar;


        if (quemar == true)
        {
            humo.SetActive(true);
        }
        else if (led_jumper == true && jumper_positivo == true && jumper_negativo == true)
        {
            humo.SetActive(true);
        }
        else if (resistencia_negativo == true && jumper_positivo == true && led_jumper == true && led_resistencia == true && jumper_jumper == true)
        {
            humo.SetActive(true);
        }

        else if (resistencia_positivo == true && jumper_negativo == true && led_jumper == true && led_resistencia == true && jumper_jumper == true)
        {
            luzLed.intensity = 10;

        }
        else
        {
            humo.SetActive(false);
            luzLed.intensity = 0.001f;
        }

        // Condición quemar
    }
}

