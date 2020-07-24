using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagement : MonoBehaviour
{
    public GameObject MS;
    public float TrueVolume;
    public static float RealVolume;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        TrueVolume = MusicVolume.CV;
        MS.GetComponent<AudioSource>().volume = TrueVolume; 
        if (CheckBoxMusic.Music == true)
        {
            CheckBoxMusic.ToggleVal = 5;
            MS.SetActive(false);
        }

        if (CheckBoxMusic.Music == false)
        {
            CheckBoxMusic.ToggleVal = 4;
            MS.SetActive(true);
        }
    }
}