using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetDog : MonoBehaviour
{
    public GameObject Shield;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            Shield.SetActive(true);
            if (ItemOnOff.SoundEffects == false)
            {
                FindObjectOfType<AudioManager>().Play("Woof");
            }
            PowerUp.PowerUpTaken = true;
            Destroy(gameObject);
        }
    }
}
