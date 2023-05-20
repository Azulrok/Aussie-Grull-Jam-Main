using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject configMenu;
    public bool onMenu;

      private void Update()
    {
    if (Input.GetKeyDown(KeyCode.Escape) && onMenu == true)
    {
        HiddenMenu();
    }
    else if (Input.GetKeyDown(KeyCode.Escape) && onMenu == false)
    {
        OpenMenu();
    }
    }

    public void HiddenMenu()
    {
        onMenu = false;
        configMenu.SetActive(false);
    }

    public void OpenMenu()
    {
        onMenu = true;
        configMenu.SetActive(true);
    }

}
