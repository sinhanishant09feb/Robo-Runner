using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeBar : MonoBehaviour
{
    public bool decrease;
    public Vector3 imagScal;
    public GameObject bijliSound;
    public GameObject electricParticle;

    // Start is called before the first frame update
    void Start()
    {
        imagScal = transform.localScale;
        decrease = false;
        StartCoroutine(reduce());
    }

    // Update is called once per frame
    void Update()
    {
       
       
        if (imagScal.x <= 0.0f)
        {
            decrease = true; ;
            SceneManager.LoadScene(4);
        }
        
        
        if(imagScal.x < 0.25f)
        {
            electricParticle.SetActive(true);
            bijliSound.SetActive(true);
        }
        else
        {
            electricParticle.SetActive(false);
            bijliSound.SetActive(false);
        }
    }

    public void dec()
    {
        if (!decrease)
            imagScal.x -= 0.0275f;
        transform.localScale = imagScal;
    }


    IEnumerator reduce()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            dec();
        }
    }
}
