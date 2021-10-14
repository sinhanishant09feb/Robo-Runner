using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundToggle : MonoBehaviour
{
    public GameObject soundToggleOn;
    public GameObject soundToggleOff;
    public void OnClickSoundButtonOn()
    {
        soundToggleOff.active = true;
        soundToggleOn.active = false;
    }
    public void OnClickSoundButtonOff()
    {
        soundToggleOff.active = false;
        soundToggleOn.active = true;
    }

}
