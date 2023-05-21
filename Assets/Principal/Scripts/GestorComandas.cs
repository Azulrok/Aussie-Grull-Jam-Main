using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorComandas : MonoBehaviour
{
    public string tagPrato;
    private List<string> menu;
    private List<string> comandas;
    private GameObject frangoBalde;
    private GameObject pratoHamburguer;
    private GameObject pratoCookie;

    private void Start()
    {
        menu = new List<string>() { "frango", "hamburguer", "cookie"};
        comandas = new List<string>();

        string randomPrato = GetRandomPrato();
        Debug.Log("Random Prato: " + randomPrato);
        // 0 frango 1 hamburguer 2 cookie
        // GameObject frangoBalde = transform.GetChild(0).gameObject;
        // GameObject pratoHamburguer = transform.GetChild(1).gameObject;
        // GameObject pratoCookie = transform.GetChild(2).gameObject;
        frangoBalde = transform.Find("frangoBalde").gameObject;
        pratoHamburguer = transform.Find("pratoHamburguer").gameObject;
        pratoCookie = transform.Find("pratoCookie").gameObject;

        ReceberComanda(randomPrato);



    }

    public string GetRandomPrato()
    {
        int randomIndex = Random.Range(0, menu.Count);
        return menu[randomIndex];
    }

    public void NovaComanda()
    {
        string randomPrato = GetRandomPrato();
        ReceberComanda(randomPrato);
    }

    private void ReceberComanda(string lista)
    {
        switch (lista)
        {
            case "frango":
                // Perform action for "frango" option
                frangoBalde.GetComponent<EntregaPrato>().mudaStatus(true);
                pratoHamburguer.GetComponent<EntregaPrato>().mudaStatus(false);
                pratoCookie.GetComponent<EntregaPrato>().mudaStatus(false);
                Debug.Log("Frango selected");
                break;

            case "hamburguer":
                // Perform action for "hamburguer" option
                frangoBalde.GetComponent<EntregaPrato>().mudaStatus(false);
                pratoHamburguer.GetComponent<EntregaPrato>().mudaStatus(true);
                pratoCookie.GetComponent<EntregaPrato>().mudaStatus(false);
                Debug.Log("Hamburguer selected");
                break;

            case "cookie":
                // Perform action for "cookie" option
                frangoBalde.GetComponent<EntregaPrato>().mudaStatus(false);
                pratoHamburguer.GetComponent<EntregaPrato>().mudaStatus(false);
                pratoCookie.GetComponent<EntregaPrato>().mudaStatus(true);
                Debug.Log("Cookie selected");
                break;

            default:
                Debug.Log("Invalid option");
                break;
        }
    }

}
