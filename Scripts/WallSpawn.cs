using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{

    public GameObject Player;
    public GameObject Platform;
    public GameObject wallComeParticle;

    [Header("Walls Hierarchy")]
    [SerializeField]
    private GameObject[] wall1 = new GameObject[3];

    [SerializeField]
    private GameObject halfWall;

    [SerializeField]
    private GameObject[] wall2 = new GameObject[3];

    [Space]
    [SerializeField]
    private float score;

    [SerializeField]
    private float spawnWall1Time;
    [SerializeField]
    private float spawnHalfWallTime;
    [SerializeField]
    private float spawnWall2Time;

    private bool b200 = false;
    private bool b2000 = false;
    private bool b4000 = false;
    private bool b10000 = false;
    private bool b15000 = false;
    private bool b20000 = false;

    Coroutine cow1;
    Coroutine coH;
    Coroutine cow2;

    // Start is called before the first frame update
    void Start()
    {
        spawnWall1Time = 6.5f;
        spawnHalfWallTime = 5.0f;
        spawnWall2Time = 4.5f;
        
    }

    // Update is called once per frame
    void Update()
    {
        score = Player.GetComponent<MovementInput>().scor;

        if(score > 200)
        {
            if (!b200)
            {
                cow1 =  StartCoroutine(spawnWall1());
                b200 = true;
            }
        }

       if(score > 2000)
        {
            if(!b2000)
            {
                StopCoroutine(cow1);
                coH = StartCoroutine(spawnHalfWall());
                b2000 = true;
            }
        }

        if (score > 4000)
        {
            if (!b4000)
            {
                b200 = false;
                b4000 = true;
            }
        }

        if(score > 10000)
        {
            if(!b10000)
            {
               StopCoroutine(cow1);
                StopCoroutine(coH);
                b200 = true;
                cow2 = StartCoroutine(spawnWall2());
                b10000 = true;
            }
        }

        if(score > 15000)
        {
            if(!b15000)
            {
                b2000 = false;
                b15000 = true;
            }
        }

        if(score > 20000)
        { 
            if(!b20000)
            {
                b200 = false;
                b20000 = true;
            }
        }

    }

    //spawn wall1 IEnumerator
    IEnumerator spawnWall1()
    {
       while(true)
        {
            yield return new WaitForSeconds(spawnWall1Time);
            //spawnWall1Fun();
        }
    }

    void spawnWall1Fun()
    { 
        int rand = Random.Range(0, 3);
        float randZ = Random.Range(Platform.transform.position.z -44, Platform.transform.position.z + 50);
        Instantiate(wallComeParticle, new Vector3(0.33f, 10.0f, randZ - 2), Quaternion.identity);
        GameObject temp =  Instantiate(wall1[rand], new Vector3(0.333f, 10.1f, randZ), Quaternion.identity);
        temp.transform.parent = Platform.transform;
    }

    //spawn wall2 IEnumerator

    IEnumerator spawnWall2()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnWall2Time);
            //spawnWall2Fun();
        }
    }

    void spawnWall2Fun()
    {
        int rand = Random.Range(0, 3);
        float randZ = Random.Range(Platform.transform.position.z - 44, Platform.transform.position.z + 50);
        Instantiate(wallComeParticle, new Vector3(0.33f, 10.0f, randZ - 2), Quaternion.identity);
        Instantiate(wall2[rand], new Vector3(0.33f, 10.1f, randZ), Quaternion.identity);
    }

    //spawn halfWall IEnumerator
    IEnumerator spawnHalfWall()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnHalfWallTime);
            spawnHalfWallFun();
        }
    }

    void spawnHalfWallFun()
    {
        float randZ = Random.Range(Platform.transform.position.z - 44, Platform.transform.position.z + 50);
        float randX = Random.Range(-2.7f, 3.2f);
        Instantiate(wallComeParticle, new Vector3(randX, 10.0f, randZ - 2), Quaternion.identity);
        GameObject temp = Instantiate(halfWall, new Vector3(randX, 10.1f, randZ), Quaternion.identity);
        temp.transform.parent = Platform.transform;
    }



}
