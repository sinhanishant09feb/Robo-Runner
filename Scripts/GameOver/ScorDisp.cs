using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorDisp : MonoBehaviour
{
    public UnityEngine.UI.Text Scor;

    private void Update()
    {
        Scor.text = PlayerPrefs.GetString("Score");
    }
}
