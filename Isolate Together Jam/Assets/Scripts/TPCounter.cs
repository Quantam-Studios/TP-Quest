using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TPCounter : MonoBehaviour
{
    public static float TP;
    Text Counter;
    public static float TPHighScore;
    public static float TPScore;

    void Start()
    {
        TP = 0;
        Counter = GetComponent<Text>();
    }

    void Update()
    {
        Counter.text = "      Collected: " + TP;
        TPScore = TP;
    }
}
