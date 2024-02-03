using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public TMPro.TMP_InputField NameInputField;

    public void NewNameEntered()
    {
        // add code here to handle when a color is selected
        MenuManager.PlayerName = NameInputField.text;
    }

    private void Awake()
    {
        NameInputField.text = MenuManager.PlayerName;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}
