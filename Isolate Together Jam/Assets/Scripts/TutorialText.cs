using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialText : MonoBehaviour
{
    public Text Description;
    public string[] Text;

    public Text Item;
    public string[] Text2;

    public Text Counter;

    // Update is called once per frame
    void Update()
    {
        Description.text = Text[TutorialManager.clickcount];
        Item.text = Text2[TutorialManager.clickcount];
        Counter.text = TutorialManager.clickcount + 1 + "/19";
    }
}
