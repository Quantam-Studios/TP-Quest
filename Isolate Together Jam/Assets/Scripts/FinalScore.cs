using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    Text finalscore;
    public float FScore;
    public static float TimeScore;
    public static float tpscore;
    public static float TrueHighScore;

    void Start()
    {
        finalscore = GetComponent<Text>();
        FScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Mathf.Floor(TimeScore);
        FScore = Mathf.Floor(TimeScore) + tpscore;
        finalscore.text = "FinalScore: " + FScore; 

        if(FScore >= TrueHighScore)
        {
            TrueHighScore = FScore;
        }
    }
}
