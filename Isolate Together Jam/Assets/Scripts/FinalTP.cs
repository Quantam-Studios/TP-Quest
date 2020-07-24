using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalTP : MonoBehaviour
{
    Text finalscore;
    public float FScore;
    public static float TPFinal;

    void Start()
    {
        finalscore = GetComponent<Text>();
        FScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Mathf.Floor(TPFinal);
        FScore = Mathf.Floor(TPFinal);
        finalscore.text = "TP Collected: " + FScore;
    }
}
