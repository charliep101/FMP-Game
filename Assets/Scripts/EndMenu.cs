using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        Scoring.totalScore = Scoring.totalScore = 0;

    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
        Scoring.totalScore = Scoring.totalScore = 0;

    }


}
