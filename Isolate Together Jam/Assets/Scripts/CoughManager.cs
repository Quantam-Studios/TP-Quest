using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoughManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int randPos = Random.Range(1, 1000);

        if ( randPos == 499)
        {
            if (ItemOnOff.SoundEffects == false)
            {
                FindObjectOfType<AudioManager>().Play("Cough");
            }
        }
    }
}
