using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOnOff : MonoBehaviour
{
    public GameObject audSrc;

    private bool toggle;
    private void Update()
    {

        if (PlayerPrefs.GetString("Music") != "Off")
            audSrc.active = true;
        else
            audSrc.active = false;
    }
}
