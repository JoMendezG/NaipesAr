using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sueloAR : DefaultTrackableEventHandler
{
   
    public Rigidbody rb;
    public bool enSuelo;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    protected override void OnTrackingFound()
    {
        // Este base nos indica que llamamos al método
        base.OnTrackingFound();

       


        // Agrego un código que permite escribir en la consola
        Debug.Log ($"<color=green><b> Found! </b></color>");
        
        
    }

     protected override void OnTrackingLost()
    {
        // Aquí llamamos al método que heredamos del código original
        base.OnTrackingLost();

        // Agrego un código que permite escribir en la consola
        Debug.Log($"<color=red><b> LOST! </b></color>");
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("enSuelo"))
        {
            enSuelo = true;
        }
    }

}
