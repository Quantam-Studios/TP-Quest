using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoredomBar : MonoBehaviour
{
    Image boredomBar;
    float maxboredom = 100f;
    float RealMaxboredom = 100f;
    float Minboredom = 0f;
    public static float boredom = 100;
    public float rateOfboredom;
    public float SetTime;
    public float GoalTime;
    public GameObject GameOverMenu;

    void Start()
    {
        boredomBar = GetComponent<Image>();
        boredom = maxboredom;
        Time.timeScale = 1;
    }

    void Update()
    {
        if (boredom < Minboredom)
        {
            boredom = 0f;
        }

        if (boredom > RealMaxboredom)
        {
            boredom = 100f;
        }

        GoalTime -= Time.deltaTime;
        if (GoalTime <= 0.0f)
        {
            timerEnded();
        }

        boredomBar.fillAmount = boredom / maxboredom;

        if (boredom <= 0)
        {
            FinalScore.TimeScore = Timer.Score;
            FinalScore.tpscore = TPCounter.TPScore;
            TimeScore.FinalTime = Timer.Score;
            FinalTP.TPFinal = TPCounter.TPScore;
            GameOverMenu.SetActive(true);
            Time.timeScale = 0;
            if (Timer.Score >= Timer.HighScore)
            {
                Timer.HighScore = Timer.Score;
            }
            Player.GameOver = true;

            if (TPCounter.TPScore >= TPCounter.TPHighScore)
            {
                TPCounter.TPHighScore = TPCounter.TPScore;
            }
        }

    }

    void timerEnded()
    {
        boredom -= rateOfboredom;
        GoalTime = 1.0f;
    }
}
