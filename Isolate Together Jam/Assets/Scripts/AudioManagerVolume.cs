using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerVolume : MonoBehaviour
{
    public GameObject MS;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (ItemOnOff.SoundEffects == true)
        {
            ItemOnOff.ToggleVal2 = 5;
            MS.SetActive(false);
        }

        if (ItemOnOff.SoundEffects == false)
        {
            ItemOnOff.ToggleVal2 = 4;
            MS.SetActive(true);
        }
    }
}
