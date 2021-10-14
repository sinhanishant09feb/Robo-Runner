using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalls1 : MonoBehaviour
{
    float initPos;
    float initPos2;
    public bool chang;
    public bool chang2;
    public GameObject[] wall1 = new GameObject[3];
    public GameObject[] wall2 = new GameObject[3];
    public GameObject wallComeParticle;
    public GameObject Player;
    public GameObject halfWall;
    public GameObject Platform;
    public GameObject[] halfWalls = new GameObject[3];
    public GameObject[] halfWalls2 = new GameObject[3];
    private float score;
    private float minDist;
    private float maxDist;
    public bool fTime;
    public bool sTime;
    public float halfWallZinit;
    private int i = 0;
    private int i2 = 0;
    public float half2;
    private void Start()
    {
        initPos  =  179;
        initPos2 = 5600;
        minDist = 150;
        maxDist = 175;
        halfWallZinit = 1500;
        chang = false;
        chang2 = false;
        fTime = true;
        sTime = true;
        half2 = 7500;
    }
    private void Update()
    {
        score = Player.GetComponent<MovementInput>().scor;
        if ((Player.transform.position.z > halfWallZinit)
            &&(Player.transform.position.z < 5500))
        {
            changHalfWall();
        }
        if(Player.transform.position.z > half2)
        {
           
            changHalfWall2();
        }

        if(score < 2000)
        {
            if (chang)
                changWall();
        }

        if((score > 2000)&&(score < 10000))
        {
            if (fTime)
            {
                minDist = 100;
                maxDist = 150;
                initPos = 2600;
                fTime = false;
            }
            if (chang)
                changWall();
        }

        if(score > 10000)
        {
            if (sTime)
            {
                minDist = 75;
                maxDist = 100;
                initPos = 10000;
                sTime = false;
            }
            if (chang)
                changWall();
        }

        if (score > 5000)
        {
            if (chang2)
            {
                changWall2();
            }
        }
    }

    public void changWall()
    {
        float randZ = Random.Range(initPos + minDist, initPos + maxDist);
        initPos = randZ;
        int rand = Random.Range(0, 3);
        Instantiate(wallComeParticle, new Vector3(0.33f, 10.0f, randZ - 2), Quaternion.identity);
        Instantiate(wall1[rand], new Vector3(0.2f, 10, initPos), Quaternion.identity);
        chang = false;
    }

    public void changWall2()
    {
        float randZ = Random.Range(initPos2 + 100, initPos2 + 125);
        initPos2 = randZ;
        int rand = Random.Range(0, 3);
        Instantiate(wallComeParticle, new Vector3(0.33f, 10.0f, randZ - 2), Quaternion.identity);
        Instantiate(wall2[rand], new Vector3(0.2f, 10, initPos2), Quaternion.identity);
        chang2 = false;
    }

    public void changHalfWall()
    {
        float halfWallX = Random.Range(-2.7f, 3.2f);
        float halfWallZ = halfWallZinit + Random.Range(50, 100);
        Instantiate(wallComeParticle, new Vector3(halfWallX + 0.1f, 10.0f, halfWallZ - 2), Quaternion.identity);
        halfWalls[i] = Instantiate(halfWall, new Vector3(halfWallX, 10, halfWallZ), Quaternion.identity);
        halfWallZinit = halfWallZ;
        switch(i)
        {
            case 0: i++;
                    Destroy(halfWalls[1].gameObject);
                    break;
            case 1: i++;
                    Destroy(halfWalls[2].gameObject);
                    break;
            case 2: i = 0;
                    Destroy(halfWalls[0].gameObject);
                    break;
        }  
    }

    public void changHalfWall2()
    {
        float halfWallX = Random.Range(-2.7f, 3.2f);
        float halfWallZ = half2 + Random.Range(50, 100);
        Instantiate(wallComeParticle, new Vector3(halfWallX + 0.1f, 10.0f, halfWallZ - 2), Quaternion.identity);
        halfWalls2[i2] = Instantiate(halfWall, new Vector3(halfWallX, 10, halfWallZ), Quaternion.identity);
        half2 = halfWallZ;
        switch (i2)
        {
            case 0:
                i2++;
                Destroy(halfWalls2[1].gameObject);
                break;
            case 1:
                i2++;
                Destroy(halfWalls2[2].gameObject);
                break;
            case 2:
                i2 = 0;
                Destroy(halfWalls2[0].gameObject);
                break;
        }
    }


}
