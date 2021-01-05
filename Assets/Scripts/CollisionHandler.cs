using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private GameObject explosion;

    
    private void OnTriggerEnter(Collider other)
    {
        this.transform.SendMessage("KillTheControls");
        explosion.SetActive(true);
        Invoke("LoadLevel" , 1);
        
    }


    private void LoadLevel()
    {
       // SceneManager.LoadScene(1);
    }
}
