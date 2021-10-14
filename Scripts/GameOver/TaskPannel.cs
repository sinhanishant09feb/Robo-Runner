using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskPannel : MonoBehaviour
{
    public GameObject scriptMgr;
    public Text task;
    public Text destroyedNo;
    private int taskint;
    public GameObject collect;
    public GameObject sound;

    private void Start()
    {
        /* PlayerPrefs.SetInt("RedWall", 0);
           PlayerPrefs.SetInt("BlueWall", 0);
           PlayerPrefs.SetInt("YellowWall", 0);
           PlayerPrefs.SetInt("HalfWall", 0);
           PlayerPrefs.SetInt("TaskOn", 0);
          PlayerPrefs.SetInt("PurpleWall", 10);
          PlayerPrefs.SetInt("OrangeWall", 10);
          PlayerPrefs.SetInt("GreenWall", 10);
          PlayerPrefs.SetFloat("Level", 0);
          PlayerPrefs.SetInt("LevelOn", 0);*/

    }

    private void Update()
    {
        task.text = scriptMgr.GetComponent<TaskManager>().tasks[PlayerPrefs.GetInt("TaskOn")];

        if (PlayerPrefs.GetInt("TaskOn") % 7 == 0)
            destroyedNo.text = PlayerPrefs.GetInt("RedWall").ToString();
        else if(PlayerPrefs.GetInt("TaskOn") % 7 == 1)
            destroyedNo.text = PlayerPrefs.GetInt("BlueWall").ToString();
        else if (PlayerPrefs.GetInt("TaskOn") % 7 == 2)
            destroyedNo.text = PlayerPrefs.GetInt("YellowWall").ToString();
        else if (PlayerPrefs.GetInt("TaskOn") % 7 == 3)
            destroyedNo.text = PlayerPrefs.GetInt("PurpleWall").ToString();
        else if (PlayerPrefs.GetInt("TaskOn") % 7 == 4)
            destroyedNo.text = PlayerPrefs.GetInt("OrangeWall").ToString();
        else if (PlayerPrefs.GetInt("TaskOn") % 7 == 5)
            destroyedNo.text = PlayerPrefs.GetInt("GreenWall").ToString();
        else if ((PlayerPrefs.GetInt("TaskOn") % 7 == 6)||
            (PlayerPrefs.GetInt("TaskOn") == 24))
            destroyedNo.text = PlayerPrefs.GetInt("HalfWall").ToString();
    }

    public void OnClickCollectSound()
    {
        sound.active = true;
    }
}
