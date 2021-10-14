using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    public GameObject changeName;
    public GameObject nameInputField;
    public GameObject submit;
   

    public UnityEngine.UI.InputField nameInput;
    public UnityEngine.UI.Text nameOnTop;

    private string nameString;

    private void Update()
    {
        nameOnTop.text = PlayerPrefs.GetString("PlayerName").ToString();
    }
    public void OnClickChangeName()
    {
        nameInputField.active = true;
        submit.active = true;
        changeName.active = false;
    }

    public void OnClickSubmit()
    {
        nameInputField.active = false;
        submit.active = false;
        changeName.active = true;
        PlayerPrefs.SetString("PlayerName", nameInput.text);
    }

    public void OnClickCancel()
    {
        nameInputField.active = false;
        submit.active = false;
        changeName.active = true;
    }

}
