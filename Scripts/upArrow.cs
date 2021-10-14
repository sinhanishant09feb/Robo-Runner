using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class upArrow : MonoBehaviour
{

    public Image upArro;

    [SerializeField]
    private float init;

    private bool movUp;
    private bool movDown;


    // Start is called before the first frame update
    void Start()
    {
        movUp = false;
        movDown = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(!movUp)
        {
             upArro.rectTransform.Translate(0, 5f, 0);
            if (upArro.rectTransform.position.y >= 105)
            {
                movUp = true;
                movDown = false;
            }

        }
            
            
        if(!movDown)
        {
            upArro.rectTransform.Translate(0, -5f, 0);
            if(upArro.rectTransform.position.y <= 15.5f)
            {
                movDown = true;
                movUp = false;
            }
        }
            

    }
}
