using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public static string character = "";
    public Button start;

    public void Start()
    {
        DontDestroyOnLoad(this);
        character = "";
    }
    public void Update()
    {
        if (character != "")
        {
            start.interactable = true;
        }
    }
    public void Char1()
    {
        character = "char1";
    }
    public void Char2()
    {
        character = "char2";
    }
    public void Char3()
    {
        character = "char3";
    }
}
