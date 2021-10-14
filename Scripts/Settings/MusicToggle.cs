using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicToggle : MonoBehaviour
{
    public GameObject musicToggleOn;
    public GameObject musicToggleOff;

    private void Start()
    {
       
    }

    public void OnClickMusicButtonOn()
    {
        musicToggleOff.active = true;
        musicToggleOn.active = false;
        PlayerPrefs.SetString("Music", "Off");
    }
   
    public void OnClickmusicButtonOff()
    {
        musicToggleOn.active = true;
        musicToggleOff.active = false;
        PlayerPrefs.SetString("Music", "On");
    } 
}
