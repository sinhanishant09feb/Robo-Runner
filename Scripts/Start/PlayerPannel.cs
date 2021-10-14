using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPannel : MonoBehaviour
{
    public UnityEngine.UI.Text Name;

    public void Update()
    {
        Name.text = PlayerPrefs.GetString("PlayerName").ToString();
    }
}
