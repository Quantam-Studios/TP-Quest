using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    public GameObject VolumeSliderGet;
    public float volume;
    public static float CurrentVolume;
    public static float CV;
    public static float NewVolume;


// Start is called before the first frame update
void Start()
    {
        volume = VolumeSliderGet.gameObject.GetComponent<Slider>().value;
        if (MusicManagement.RealVolume != 100)
        {
            VolumeSliderGet.gameObject.GetComponent<Slider>().value = MusicManagement.RealVolume;
        }
    }

    // Update is called once per frame
    void Update()
    {
      //  volume = MusicManagement.RealVolume;

        CurrentVolume = volume;
        CV = CurrentVolume / 100;
    }

    public void OnValueChanged(float newValue)
    {
        volume = newValue;
        MusicManagement.RealVolume = newValue;
        DefaultSettings.onChange = true;
        DefaultSettings.Volume2 = newValue;
    }
}
