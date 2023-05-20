using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string sceneName;
    public Animator transition;
    public GameObject[] menus;

    public void StartGame()
    {
        StartCoroutine(LoadLevel());
    }
    public void LoadGame()
    {

    }
    public void OpenSettings()
    {
        if (menus[0].active)
        {
            menus[0].SetActive(false);
            menus[1].SetActive(true);
        }
        else if (menus[1].active)
        {
            menus[0].SetActive(true);
            menus[1].SetActive(false);
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(sceneName);  
    }
}
