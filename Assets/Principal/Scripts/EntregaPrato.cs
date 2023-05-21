using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntregaPrato : MonoBehaviour
{
    private bool isActive = false;
    private GameObject manager;

    void Start()
    {
        manager = transform.parent.gameObject;
    }


    public void mudaStatus(bool option)
    {
        if (option == true)
            isActive = true;
        else
            isActive = false;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (gameObject.tag == other.gameObject.tag && isActive)
        {
            print("prato certo");
            other.gameObject.transform.position = new Vector2(-24.4f,2.9f);
            other.gameObject.GetComponent<Alimento>().destroiObjeto();
            InfoUI.pontos = InfoUI.pontos +1;
            // manager.GetComponent<GestorComandas>().NovaComanda();
        }
        else if (other.gameObject.tag != "Player" )//&& other.gameObject.tag != gameObject.tag) 
        {
            print("prato errado");
            other.gameObject.transform.position = new Vector2(-24.4f,2.9f);
            other.gameObject.GetComponent<Alimento>().destroiObjeto();
        }
    }
}



