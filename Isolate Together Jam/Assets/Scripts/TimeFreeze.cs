using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFreeze : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            if (ItemOnOff.SoundEffects == false)
            {
                FindObjectOfType<AudioManager>().Play("Tick");
            }
            PowerUp.PowerUpTaken = true;
            Progressive.slowOrNot = true;
            Sickpeople.slowOrNot = true;
            Destroy(gameObject);
        }
        if (col.collider.tag == "Dog")
        {
            if (ItemOnOff.SoundEffects == false)
            {
                FindObjectOfType<AudioManager>().Play("Tick");
            }
            PowerUp.PowerUpTaken = true;
            Progressive.slowOrNot = true;
            Sickpeople.slowOrNot = true;
            Destroy(gameObject);

        }
    }
}
