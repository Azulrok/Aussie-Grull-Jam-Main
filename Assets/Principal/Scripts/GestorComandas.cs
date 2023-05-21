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
        GameObject frangoBalde = transform.Find("frangoBalde").gameObject;
        GameObject pratoHamburguer = transform.Find("pratoHamburguer").gameObject;
        GameObject pratoCookie = transform.Find("pratoCookie").gameObject;



    }

    private string GetRandomPrato()
    {
        int randomIndex = Random.Range(0, menu.Count);
        return menu[randomIndex];
    }

    private void ReceberComanda(string lista)
    {
        switch (lista)
        {
            case "frango":
                // Perform action for "frango" option
                Debug.Log("Frango selected");
                break;

            case "hamburguer":
                // Perform action for "hamburguer" option
                Debug.Log("Hamburguer selected");
                break;

            case "cookie":
                // Perform action for "cookie" option
                Debug.Log("Cookie selected");
                break;

            default:
                Debug.Log("Invalid option");
                break;
        }
    }

}
