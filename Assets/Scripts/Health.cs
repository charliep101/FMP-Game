using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text scoreText;
   
    void Start()
    {
        
        scoreText.text = "Score: " + Scoring.totalScore;
    }

    void Update()
    {
        
    }




    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);
            Scoring.totalScore = Scoring.totalScore + 1;
            scoreText.text = "Score: " + Scoring.totalScore;
        }

    }

}
