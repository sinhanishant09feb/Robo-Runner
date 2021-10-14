using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject pausBtn;
    public GameObject pannel;
    public GameObject otherBtnSound;
    public bool pause; 
    void Start()
    {
        pause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pause)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    public void onClickPause()
    {
        otherBtnSound.active = true;
        pause = true;
        pannel.active = true;
        pausBtn.active = false;
    }

    public void OnClickResume()
    {
        otherBtnSound.active = true;
        pause = false;
        pausBtn.active = true;
        pannel.active = false;
    }
}
