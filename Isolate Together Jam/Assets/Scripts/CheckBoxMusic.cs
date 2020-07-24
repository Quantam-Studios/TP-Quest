using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckBoxMusic : MonoBehaviour
{
    public Sprite ON;
    public Sprite OFF;
    public Button button;
    public GameObject onText;
    public GameObject offText;
    public static float ToggleVal;
    public Sprite Current;

    public static bool Music;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ToggleVal % 2 == 0)
        {
            Current = OFF;
            Music = false;
            onText.SetActive(false);
            offText.SetActive(true);
            this.button.GetComponent<Image>().sprite = ON;
        }
        if(ToggleVal % 2 == 1)
        {
            Current = ON;
            Music = true;
            onText.SetActive(true);
            offText.SetActive(false);
            this.button.GetComponent<Image>().sprite = OFF;
        }
    }

    public void Toggle()
    {
       // this.button.GetComponent<Image>().sprite = Current;
        ToggleVal += 1;
    }
}
