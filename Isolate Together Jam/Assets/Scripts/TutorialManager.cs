using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[System.Serializable]

public class TutorialManager : MonoBehaviour
{
    public GameObject[][] TutorialParts;
    public GameObject[] PlayerArrow;
    public GameObject[] SafeZoneArrow;
    public GameObject[] WallArrows;
    public GameObject[] NormalArrow;
    public GameObject[] SickArrow;
    public GameObject[] TPArrow;
    public GameObject[] GoldenTPArrow;
    public GameObject[] TPCounterArrow;
    public GameObject[] CanArrow;
    public GameObject[] CanCounterArrow;
    public GameObject[] WaterArrow;
    public GameObject[] WaterCounterArrow;
    public GameObject[] ControllerArrow;
    public GameObject[] BookArrow;
    public GameObject[] EntertainmentCounterArrow;
    public GameObject[] DogArrow;
    public GameObject[] TimeFreezeArrow;
    public GameObject[] VaccineArrow;
    public GameObject[] ImmortalArrow;
    public static int clickcount = 0;
    public int currentSize;
    public int currentSizeOffset;
    public int selected;
    public int clickOffset;

    // Start is called before the first frame update
    void Start()
    {
        clickcount = 0;
        TutorialParts = new GameObject[19][];
        TutorialParts[0] = PlayerArrow;
        TutorialParts[1] = SafeZoneArrow;
        TutorialParts[2] = WallArrows;
        TutorialParts[3] = NormalArrow;
        TutorialParts[4] = SickArrow;
        TutorialParts[5] = TPArrow;
        TutorialParts[6] = GoldenTPArrow;
        TutorialParts[7] = TPCounterArrow;
        TutorialParts[8] = CanArrow;
        TutorialParts[9] = CanCounterArrow;
        TutorialParts[10] = WaterArrow;
        TutorialParts[11] = WaterCounterArrow;
        TutorialParts[12] = ControllerArrow;
        TutorialParts[13] = BookArrow;
        TutorialParts[14] = EntertainmentCounterArrow;
        TutorialParts[15] = DogArrow;
        TutorialParts[16] = TimeFreezeArrow;
        TutorialParts[17] = VaccineArrow;
        TutorialParts[18] = ImmortalArrow;

        for (int i = 0; i < TutorialParts.Length; i++)
        {
            GameObject[] Part = TutorialParts[i];
            int PartSize = Part.Length -1;
            Part[PartSize].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (clickcount < 18)
            {
                clickcount += 1;
                currentSize = 0;
            }
        }

        TutorialParts[clickcount][currentSize].SetActive(true);
        currentSize = TutorialParts[clickcount].Length - 1;

        clickOffset = clickcount - 1;
        if (clickOffset >= 0)
        {
            TutorialParts[clickOffset][currentSizeOffset].SetActive(false);
            currentSizeOffset = TutorialParts[clickOffset].Length - 1;
        }

    }
}
