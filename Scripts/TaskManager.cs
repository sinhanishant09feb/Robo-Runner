using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{

    public string[] tasks = new string[25];

    public GameObject Collect;

    private void Start()
    {
        tasks[0] = "Destroy 10 RedWalls";
        tasks[1] = "Destroy 10 BlueWalls";
        tasks[2] = "Destroy 10 YellowWalls";
        tasks[3] = "Destroy 10 PurpleWalls";
        tasks[4] = "Destroy 10 OrangeWalls";
        tasks[5] = "Destroy 10 GreenWalls";
        tasks[6] = "Destroy 5 HalfWalls";
        tasks[7] = "Destroy 50 RedWalls";
        tasks[8] = "Destroy 50 BlueWalls";
        tasks[9] = "Destroy 50 YellowWalls";
        tasks[10] = "Destroy 50 PurpleWalls";
        tasks[11] = "Destroy 50 OrangeWalls";
        tasks[12] = "Destroy 50 GreenWalls";
        tasks[13] = "Destroy 10 HalfWalls";
        tasks[14] = "Destroy 100 RedWalls";
        tasks[15] = "Destroy 100 BlueWalls";
        tasks[16] = "Destroy 100 YellowWalls";
        tasks[17] = "Destroy 100 PurpleWalls";
        tasks[18] = "Destroy 100 OrangeWalls";
        tasks[19] = "Destroy 100 GreenWalls";
        tasks[20] = "Destroy 50 HalfWalls";
        tasks[21] = "Destroy 500 RedWalls";
        tasks[22] = "Destroy 500 BlueWalls";
        tasks[23] = "Destroy 500 YellowWalls";
        tasks[24] = "Destroy 100 HalfWalls";
    }


    public void OnClickCollect()
    {
        Collect.active = false;
        int temp = PlayerPrefs.GetInt("TaskOn");
        if(temp<=24)
         temp++;
        PlayerPrefs.SetInt("TaskOn", temp);
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("RedWall") < 10)
            PlayerPrefs.SetInt("TaskOn", 0);
        if ((PlayerPrefs.GetInt("RedWall") >= 10) && (PlayerPrefs.GetInt("TaskOn") == 0))
        {
            Collect.active = true;
        }    
        if((PlayerPrefs.GetInt("BlueWall") >= 10) && (PlayerPrefs.GetInt("TaskOn") == 1))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("YellowWall") >= 10) && (PlayerPrefs.GetInt("TaskOn") == 2))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("PurpleWall") >= 10) && (PlayerPrefs.GetInt("TaskOn") == 3))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("OrangeWall") >= 10) && (PlayerPrefs.GetInt("TaskOn") == 4))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("GreenWall") >= 10) && (PlayerPrefs.GetInt("TaskOn") == 5))
        {
            Collect.active = true;
        }
        if((PlayerPrefs.GetInt("HalfWall")>= 5)&&(PlayerPrefs.GetInt("TaskOn") == 6))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("RedWall") >= 50) && (PlayerPrefs.GetInt("TaskOn") == 7))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("BlueWall") >= 50) && (PlayerPrefs.GetInt("TaskOn") == 8))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("YellowWall") >= 50) && (PlayerPrefs.GetInt("TaskOn") == 9))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("PurpleWall") >= 50) && (PlayerPrefs.GetInt("TaskOn") == 10))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("OrangeWall") >= 50) && (PlayerPrefs.GetInt("TaskOn") == 11))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("GreenWall") >= 50) && (PlayerPrefs.GetInt("TaskOn") == 12))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("HalfWall") >= 10) && (PlayerPrefs.GetInt("TaskOn") == 13))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("RedWall") >= 100) && (PlayerPrefs.GetInt("TaskOn") == 14))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("BlueWall") >= 100) && (PlayerPrefs.GetInt("TaskOn") == 15))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("YellowWall") >= 100) && (PlayerPrefs.GetInt("TaskOn") == 16))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("PurpleWall") >= 100) && (PlayerPrefs.GetInt("TaskOn") == 17))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("OrangeWall") >= 100) && (PlayerPrefs.GetInt("TaskOn") == 18))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("GreenWall") >= 100) && (PlayerPrefs.GetInt("TaskOn") == 19))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("HalfWall") >= 50) && (PlayerPrefs.GetInt("TaskOn") == 20))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("RedWall") >= 500) && (PlayerPrefs.GetInt("TaskOn") == 21))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("BlueWall") >= 500) && (PlayerPrefs.GetInt("TaskOn") == 22))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("YellowWall") >= 500) && (PlayerPrefs.GetInt("TaskOn") == 23))
        {
            Collect.active = true;
        }
        if ((PlayerPrefs.GetInt("HalfWall") >= 100) && (PlayerPrefs.GetInt("TaskOn") == 24))
        {
            Collect.active = true;
        }
    }
}
