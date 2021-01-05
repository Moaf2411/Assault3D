using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    
    private AudioSource audio;
    private void Awake()
    {
        if (FindObjectsOfType<MusicPlayer>().Length == 1)
        {
                DontDestroyOnLoad(this);
                audio = GetComponent<AudioSource>();
                audio.PlayOneShot(audio.clip);
        }

        else
        {
           
            Destroy(this);
            
        }

        
        
        
        
        
        
    }

    
}
