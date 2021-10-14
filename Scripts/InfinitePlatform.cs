using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InfinitePlatform : MonoBehaviour
{
    [Header("Platforms")]
    public GameObject prefabPlatform;
    public Joystick joystick;

    public Transform startpos;
    public bool isPlatNew = false;

    [Header("Boundary")]
    [Range(5.0f, 6.0f)]
    public float bound = 5.75f;

    [Header("The Player")]
    public GameObject player;
    public int i = 0;
    private int nextPlatformDist = 192;
    public GameObject Paus;
    public GameObject bijliSound;
    public GameObject PTime;
    public GameObject ElectricParticle;
    public Image bar;
    public GameObject[] spawnedPlatform;
    public int id= 0;
    private int index = 0;


    public void Start()
    {
        bound = 5.75f;
        spawnedPlatform = new GameObject[4];
    }
    public void Update()
    {
        if((player.transform.position.x < (-1 * bound))||(player.transform.position.x > (bound+0.15)))
        {
            player.GetComponent<MovementInput>().InputZ = 0;
            player.GetComponent<MovementInput>().InputX = 0;
            player.GetComponent<MovementInput>().movFrd = false;
            player.GetComponent<MovementInput>().movSide = false;
            ElectricParticle.SetActive(true);
            Handheld.Vibrate();
            bijliSound.active = true;
            StartCoroutine(parOn());

        }
    }

   


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag.Equals("Finish"))
        {
            foreach(Transform child in prefabPlatform.transform)
            {
                if (child.tag.Equals("wall"))
                    GameObject.Destroy(child.gameObject);
            }
            spawnedPlatform[i] = Instantiate(prefabPlatform, new Vector3(startpos.position.x, startpos.position.y, (startpos.position.z) + nextPlatformDist), Quaternion.identity);
            nextPlatformDist += 96;
            isPlatNew = true;
            switch (i)
            {
                case 0: i++;
                        desPlat(1);
                        break;
                case 1: i++;
                        desPlat(2);
                        break;
                case 2: i++;
                        desPlat(3);
                        break;
                case 3: i = 0;
                        desPlat(0);
                        break;

            }

          
    
            // Debug.Log("I have Entered");

            bar.GetComponent<TimeBar>().imagScal.x = 1.02f;

            Instantiate(PTime, this.transform.position, Quaternion.identity);

            
        }

        if (collision.gameObject.tag.Equals("collect"))
        {
            Destroy(collision.gameObject);
        }

    }

   


    private void Instantiate(GameObject prefabPlatform, Vector3 vector3)
    {
        throw new NotImplementedException();
    }

    public void desPlat(int ind)
    {
        GameObject temp = spawnedPlatform[ind];
        Destroy(temp);
        //Debug.Log(ind + "Destroyed");
    }

    IEnumerator parOn()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(4);
        }
    }
}
