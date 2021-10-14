using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnBakhodi : MonoBehaviour
{
    [Header("Balls")]
    public GameObject[] balls = new GameObject[4];

    [Header("Buttons")]
    public Transform[] buttons = new Transform[4];

    public Transform player;

    public GameObject P;

    [Header("spawn at")]
    private float x  = 1.5f, y = 1.0f, z = 0;

    public Text PowerBallRem;
    public float powerBallRemF = 3;

    public void Start()
    {
        if (PlayerPrefs.GetInt("LevelOn") < 3)
            powerBallRemF = 3;
        else if (PlayerPrefs.GetInt("LevelOn") < 6)
            powerBallRemF = 4;
        else
            powerBallRemF = 5;

    }

    public void Update()
    {
        PowerBallRem.text = powerBallRemF.ToString();
    }

    public void spawnRedBall()
    {
        if (Time.timeScale != 0)
        {
           
            Instantiate(
                balls[0],
                new Vector3(player.position.x + x, player.position.y + y, player.position.z + z),
                Quaternion.identity
                );
        }
    }

    public void spawnBlueBall()
    {
        if (Time.timeScale != 0)
        {
            
            Instantiate(
            balls[1],
            new Vector3(player.position.x + x, player.position.y + y, player.position.z + z),
            Quaternion.identity
            );
        }
    }

    public void spawnBlackBall()
    {
        if (Time.timeScale != 0)
        {
            
            Instantiate(
            balls[2],
            new Vector3(player.position.x + x, player.position.y + y, player.position.z + z),
            Quaternion.identity
            );
        }
    }

    public void spawnPowerBall()
    {
        if(Time.timeScale != 0)
        {
            if (powerBallRemF > 0)
            {
                
                Instantiate(
               balls[3],
               new Vector3(player.position.x + x, player.position.y + y, player.position.z + z),
               Quaternion.identity
                   );
                powerBallRemF--;
            }
        }
    }

   
}
