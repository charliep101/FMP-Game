using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmouredEnemy : MonoBehaviour
{
    [SerializeField] private float eHealth = 5;

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
            eHealth = eHealth - 1;
            
        }
        if (eHealth < 1)
        {
            Destroy(col.gameObject);
            Scoring.totalScore = Scoring.totalScore + 5;
            scoreText.text = "Score: " + Scoring.totalScore;
        }

    }
}
