using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void EventHandler(object sender, EventArgs e);
public class ScoreDetails : EventArgs
{
    public int scorePerHit;
}
public class ScoreBoard : MonoBehaviour
{
    private int score;
    private Text t;
    
    
    
    

            private void Awake()
            {
                t = GetComponent<Text>();
                score = 0;
                t.text = score.ToString();
                Enemy.ScoreEvent += ScoreHit;
                
            }

            


            private void ScoreHit(object sender , ScoreDetails s)
            {
                score += s.scorePerHit;
                t.text = score.ToString();
            }
    
    
    
    
    
    
    
    
    
}
