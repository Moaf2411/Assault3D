using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    private void Start()
    {
        Invoke("LoadFirstScene" , 5);
    }


    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
