using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorComandas : MonoBehaviour
{
    public string tagPrato;
    private List<string> menu;
    private List<string> comandas;

    private void Start()
    {
        menu = new List<string>() { "frango", "hamburguer", "cookie"};
        comandas = new List<string>();

        string randomPrato = GetRandomPrato();
        Debug.Log("Random Prato: " + randomPrato);
    }

    private string GetRandomPrato()
    {
        int randomIndex = Random.Range(0, menu.Count);
        return menu[randomIndex];
    }

}
