using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{
    public Transform Player;
    private bool runT = false;
    private bool hitT = false;
    private bool hitTEnd = false;
    public GameObject btnPtr;
    public GameObject runPtr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.position.z > 5)
        {
            if (!runT)
            {
                runPtr.SetActive(false);
                runT = true;
            }
        }
        

        if(Player.position.z > 150)
        {
            if(!hitT)
            {
                //spawn
                btnPtr.SetActive(true);
                hitT = true;
            }
        }

        if(Player.position.z > 201)
        {
            if(!hitTEnd)
            {
                btnPtr.SetActive(false);
                hitTEnd = true;
            }
        }
    }
}
