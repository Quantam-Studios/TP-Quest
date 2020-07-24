using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemOnOff : MonoBehaviour
{
    public Sprite ON;
    public Sprite OFF;
    public Button button;
    public GameObject onText;
    public GameObject offText;
    public static float ToggleVal2;
    public Sprite Current;

    public static bool SoundEffects;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ToggleVal2 % 2 == 0)
        {
            Current = OFF;
            SoundEffects = false;
            onText.SetActive(false);
            offText.SetActive(true);
            this.button.GetComponent<Image>().sprite = ON;
        }
        if (ToggleVal2 % 2 == 1)
        {
            Current = ON;
            SoundEffects = true;
            onText.SetActive(true);
            offText.SetActive(false);
            this.button.GetComponent<Image>().sprite = OFF;
        }
    }

    public void Toggle()
    {
        // this.button.GetComponent<Image>().sprite = Current;
        ToggleVal2 += 1;
    }
}
