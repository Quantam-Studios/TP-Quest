using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirstBar : MonoBehaviour
{
    Image thirstBar;
    float maxThirst = 100f;
    float RealMaxThirst = 100f;
    float MinThirst = 0f;
    public static float Thirst = 100;
    public float rateOfThirst;
    public float SetTime;
    public float GoalTime;
    public GameObject GameOverMenu;

    void Start()
    {
        thirstBar = GetComponent<Image>();
        Thirst = maxThirst;
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Thirst < MinThirst)
        {
            Thirst = 0f;
        }

        if (Thirst > RealMaxThirst)
        {
            Thirst = 100f;
        }

        GoalTime -= Time.deltaTime;
        if (GoalTime <= 0.0f)
        {
            timerEnded();
        }

        thirstBar.fillAmount = Thirst / maxThirst;

        if (Thirst <= 0)
        {
            FinalScore.TimeScore = Timer.Score;
            FinalScore.tpscore = TPCounter.TPScore;
            TimeScore.FinalTime = Timer.Score;
            FinalTP.TPFinal = TPCounter.TPScore;
            Player.GameOver = true;
            GameOverMenu.SetActive(true);
            Time.timeScale = 0;
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
        Thirst -= rateOfThirst;
        GoalTime = 1.0f;
    }
}
