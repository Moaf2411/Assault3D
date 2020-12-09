using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    private AudioSource audio;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(audio.clip);
        Invoke("LoadFirstScene" , 5);
        
        
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
