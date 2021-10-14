using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenload : MonoBehaviour
{
    public Image img;
    public Vector3 imagScal;

    // Start is called before the first frame update
    void Start()
    {
        imagScal  = img.transform.localScale;
        //start asynchronization
        StartCoroutine(loadGame());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator loadGame()
    {
        AsyncOperation gameLevel = SceneManager.LoadSceneAsync(2);
        
        while(gameLevel.progress < 1)
        {
            imagScal.x = gameLevel.progress;
            img.transform.localScale = imagScal;
            yield return new WaitForEndOfFrame();
        }

        
    }
}
