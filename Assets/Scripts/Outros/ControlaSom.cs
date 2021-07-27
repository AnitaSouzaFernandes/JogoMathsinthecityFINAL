using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaSom : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("Som", 1);

        if (PlayerPrefs.GetInt("Som") == 1)
        {
            //Camera.main.GetComponent<AudioListener>().volume = 0;
            AudioListener.volume = 1;

        }
        else
        {
            //Camera.main.GetComponent<AudioListener>().volume = ;
            AudioListener.volume = 0;

        }

    }

 }
