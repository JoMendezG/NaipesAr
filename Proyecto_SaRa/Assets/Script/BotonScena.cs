using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonScena : MonoBehaviour
{
    public void Cambio_LedScene()
    {
        SceneManager.LoadScene("LedLevel");
    }
    public void Cambio_LedRGBScene()
    {
        SceneManager.LoadScene("LedRGBLevel");
    }
    public void Cambio_ResistenciaScene()
    {
        SceneManager.LoadScene("ResistenciaLevel");
    }
    public void Cambio_PulsadorScene()
    {
        SceneManager.LoadScene("PulsadorLed");
    }
    public void Cambio_MotorDcScene()
    {
        SceneManager.LoadScene("MotorDcLevel");
    }
    public void Cambio_PotenciometroScene()
    {
        SceneManager.LoadScene("PotenciometroLevel");
    }
    public void Cambio_MenuCarrusel()
    {
        SceneManager.LoadScene("SwipeMenu");
    }    

}