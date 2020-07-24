using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScore : MonoBehaviour
{
    Text finalscore;
    public float FScore;
    public static float FinalTime;

    void Start()
    {
        finalscore = GetComponent<Text>();
        FScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Mathf.Floor(FinalTime);
        FScore = Mathf.Floor(FinalTime);
        finalscore.text = "Time: " + FScore;
    }
}
