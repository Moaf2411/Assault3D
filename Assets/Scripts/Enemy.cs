using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Enemy : MonoBehaviour
{

   
    [SerializeField] private int s;
    [SerializeField] private int health;
    private ScoreDetails sd;

    public static event EventHandler<ScoreDetails> ScoreEvent;
    
    private void Awake()
    {
        sd=new ScoreDetails();
        sd.scorePerHit = s;
       

    }

    private int hit = 0;
    [SerializeField] private GameObject deathFx;
    
    
                private void OnParticleCollision(GameObject other)
                {
                    
                    hit++;
            
                    if (hit > health)
                    {
                        hit = -1000;
                        Instantiate(deathFx, this.transform.position, Quaternion.identity);
                        ScoreEvent(this, sd);
                        
                        
                        
                        Destroy(this.gameObject);
                    }
                        
                }



    
}
