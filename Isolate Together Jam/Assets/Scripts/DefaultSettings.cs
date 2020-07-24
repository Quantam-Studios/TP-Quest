using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultSettings : MonoBehaviour
{
    public static bool onChange;
    public static float Volume2;

    public static DefaultSettings instance = null;

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)
        {
            //if not, set instance to this
            instance = this;
        }
        //If instance already exists and it's not this:
        else if (instance != this)
        {
            Destroy(gameObject);
        }


        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

    }

    private void Start()
    {
        onChange = false;
        MusicVolume.CV = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(onChange == false)
        {
            MusicManagement.RealVolume = 60;
        }

        if(onChange == true)
        {
            MusicManagement.RealVolume = Volume2;
        }
    }
}
