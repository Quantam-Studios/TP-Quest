using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanofFood : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            HungerBar.hunger += 25;
            if (ItemOnOff.SoundEffects == false)
            {
                FindObjectOfType<AudioManager>().Play("Eat");
            }
            ItemSpawn.foodTaken = true;
            Destroy(gameObject);
        }

        if (col.collider.tag == "Dog")
        {
            HungerBar.hunger += 25;
            if (ItemOnOff.SoundEffects == false)
            {
                FindObjectOfType<AudioManager>().Play("Eat");
            }
            ItemSpawn.foodTaken = true;
            Destroy(gameObject);
        }
    }
}
