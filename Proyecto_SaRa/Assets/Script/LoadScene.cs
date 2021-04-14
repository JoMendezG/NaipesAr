using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LoadScene : MonoBehaviour
{

    public string SCENE;
    public void Changescene(string SCENE)
    {
        SceneManager.LoadScene(SCENE);
    }
}
