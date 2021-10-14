using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personalize : MonoBehaviour
{

    public Vector3 imagScal;
    public Text LevelOnText;
    public Image RedBar;
    public Image BlueBar;
    public Image YellowBar;


    private void Start()
    {
        imagScal.x = PlayerPrefs.GetFloat("Level");
        imagScal.y = 1;
        imagScal.z = 1;
        transform.localScale = imagScal;
        LevelOnText.text = PlayerPrefs.GetInt("LevelOn").ToString();
    }

    private void Update()
    {

    }


    public void OnClickCollect()
    {
        float temp = imagScal.x;
        if (temp <= 0.8f)
            temp += 0.2f;
        else
        {
            int tempLev = int.Parse(LevelOnText.text);
            tempLev++;
            PlayerPrefs.SetInt("LevelOn", tempLev);
            LevelOnText.text = PlayerPrefs.GetInt("LevelOn").ToString();
            temp = 0;
        }
        imagScal.x = temp;
        transform.localScale = imagScal;
        PlayerPrefs.SetFloat("Level", temp);
    }


    public void changBallLevel()
    {
       /* if (PlayerPrefs.GetInt("TaskOn") % 7 == 0)
            destroyedNo.text = PlayerPrefs.GetInt("RedWall").ToString();
        else if (PlayerPrefs.GetInt("TaskOn") % 7 == 1)
            destroyedNo.text = PlayerPrefs.GetInt("BlueWall").ToString();
        else if (PlayerPrefs.GetInt("TaskOn") % 7 == 2)
            destroyedNo.text = PlayerPrefs.GetInt("YellowWall").ToString();
        else if (PlayerPrefs.GetInt("TaskOn") % 7 == 3)
            destroyedNo.text = PlayerPrefs.GetInt("PurpleWall").ToString();
        else if (PlayerPrefs.GetInt("TaskOn") % 7 == 4)
            destroyedNo.text = PlayerPrefs.GetInt("OrangeWall").ToString();
        else if (PlayerPrefs.GetInt("TaskOn") % 7 == 5)
            destroyedNo.text = PlayerPrefs.GetInt("GreenWall").ToString();
        else if ((PlayerPrefs.GetInt("TaskOn") % 7 == 6) ||
            (PlayerPrefs.GetInt("TaskOn") == 24))
            destroyedNo.text = PlayerPrefs.GetInt("HalfWall").ToString();*/
    }
}
