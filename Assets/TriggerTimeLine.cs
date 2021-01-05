using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeLine : MonoBehaviour
{
    [SerializeField] private PlayableDirector pd;

    private void Awake()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        pd.Play();
    }
}
