using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerCustomization : MonoBehaviour
{
    // Face Color
    public Color[] FaceCol;
    public static Color[] TrueFaceCol; 
    public Image FaceObj;
    public static int FaceActive;
    public int faceactive;

    // Jacket Color
    public Color[] JacketCol;
    public static Color[] TrueJacketCol;
    public Image JacketObj;
    public static int JacketActive;
    public int jacketactive;

    // Shirt Color
    public Color[] ShirtCol;
    public static Color[] TrueShirtCol;
    public Image ShirtObj;
    public static int ShirtActive;
    public int Shirtactive;

    // Pants Color
    public Color[] PantsCol;
    public static Color[] TruePantsCol;
    public Image PantsObj;
    public static int PantsActive;
    public int pantsactive;

    // Edit Stuff
    public GameObject CustomButtons;
    public GameObject EditButton;
    public GameObject DoneButton;
    // Shirt toggle button stuff
    public GameObject ShirtButton;
    public GameObject ShirtArrows;
    // Jacket toggle button stuff
    public GameObject JacketButton;
    public GameObject JacketArrows;

    // Start is called before the first frame update
    void Start()
    {
        // Face stuff
        FaceObj.GetComponent<Image>().color = FaceCol[FaceActive];
        TrueFaceCol = new Color[FaceCol.Length];
        for (int i = 0; FaceCol.Length > i; i++)
        {
            TrueFaceCol[i] = FaceCol[i];
        }

        // Jacket stuff
        JacketObj.GetComponent<Image>().color = JacketCol[JacketActive];
        TrueJacketCol = new Color[JacketCol.Length];
        for (int i = 0; JacketCol.Length > i; i++)
        {
            TrueJacketCol[i] = JacketCol[i];
        }

        // Shirt stuff
        ShirtObj.GetComponent<Image>().color = ShirtCol[ShirtActive];
        TrueShirtCol = new Color[ShirtCol.Length];
        for (int i = 0; ShirtCol.Length > i; i++)
        {
            TrueShirtCol[i] = ShirtCol[i];
        }

        // Pants stuff
        PantsObj.GetComponent<Image>().color = PantsCol[PantsActive];
        TruePantsCol = new Color[PantsCol.Length];
        for (int i = 0; PantsCol.Length > i; i++)
        {
            TruePantsCol[i] = PantsCol[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
       // FaceObj.GetComponent<Image>().color = FaceCol[FaceActive];
    }

    public void HeadLeft()
    {
        if (FaceActive > 0)
        {
            FaceActive -= 1;
        }

        FaceObj.GetComponent<Image>().color = FaceCol[FaceActive];
    }

    public void HeadRight()
    {
        if (FaceActive < FaceCol.Length - 1)
        {
            FaceActive += 1;
        }

        FaceObj.GetComponent<Image>().color = FaceCol[FaceActive];
    }

    public void JacketLeft()
    {
        if (JacketActive > 0)
        {
            JacketActive -= 1;
        }

        JacketObj.GetComponent<Image>().color = JacketCol[JacketActive];
    }

    public void JacketRight()
    {
        if (JacketActive < JacketCol.Length - 1)
        {
            JacketActive += 1;
        }

        JacketObj.GetComponent<Image>().color = JacketCol[JacketActive];
    }

    public void ShirtLeft()
    {
        if (ShirtActive > 0)
        {
            ShirtActive -= 1;
        }

        ShirtObj.GetComponent<Image>().color = ShirtCol[ShirtActive];
    }

    public void ShirtRight()
    {
        if (ShirtActive < ShirtCol.Length - 1)
        {
            ShirtActive += 1;
        }

        ShirtObj.GetComponent<Image>().color = ShirtCol[ShirtActive];
    }

    public void PantsLeft()
    {
        if (PantsActive > 0)
        {
            PantsActive -= 1;
        }

        PantsObj.GetComponent<Image>().color = PantsCol[PantsActive];
    }

    public void PantsRight()
    {
        if (PantsActive < PantsCol.Length - 1)
        {
            PantsActive += 1;
        }

        PantsObj.GetComponent<Image>().color = PantsCol[PantsActive];
    }

    public void Edit()
    {
        CustomButtons.SetActive(true);
        DoneButton.SetActive(true);
        EditButton.SetActive(false);
    }

    public void Done()
    {
        CustomButtons.SetActive(false);
        DoneButton.SetActive(false);
        EditButton.SetActive(true);
    }

    public void Shirt()
    {
        ShirtArrows.SetActive(true);
        JacketArrows.SetActive(false);
        ShirtButton.SetActive(false);
        JacketButton.SetActive(true);
    }

    public void Jacket()
    {
        JacketArrows.SetActive(true);
        ShirtArrows.SetActive(false);
        JacketButton.SetActive(false);
        ShirtButton.SetActive(true);
    }
}
