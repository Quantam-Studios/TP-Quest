using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    Image foodBar;
    float maxHunger = 100f;
    float RealMaxHunger = 100f;
    float MinHunger = 0f;
    public static float hunger = 100;
    public float rateOfHunger;
    public float SetTime;
    public float GoalTime;
    public GameObject GameOverMenu;

    void Start()
    {
        foodBar = GetComponent<Image>();
        hunger = maxHunger;
        Time.timeScale = 1;
    }

    void Update()
    {
        if (hunger < MinHunger)
        {
            hunger = 0f;
            
        }

        if (hunger > RealMaxHunger)
        {
            hunger = 100f;
        }

        GoalTime -= Time.deltaTime;
        if (GoalTime <= 0.0f)
        {
            timerEnded();
        }

        foodBar.fillAmount = hunger / maxHunger;

        if (hunger <= 0)
        {
            FinalScore.TimeScore = Timer.Score;
            FinalScore.tpscore = TPCounter.TPScore;
            TimeScore.FinalTime = Timer.Score;
            FinalTP.TPFinal = TPCounter.TPScore;
            GameOverMenu.SetActive(true);
            Time.timeScale = 0;
            Player.GameOver = true;
            if (Timer.Score >= Timer.HighScore)
            {
                Timer.HighScore = Timer.Score;
            }

            if (TPCounter.TPScore >= TPCounter.TPHighScore)
            {
                TPCounter.TPHighScore = TPCounter.TPScore;
            }
        }

    }

    void timerEnded()
    {
        hunger -= rateOfHunger;
        GoalTime = 1.0f;
    }
}
