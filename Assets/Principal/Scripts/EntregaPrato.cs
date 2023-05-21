using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntregaPrato : MonoBehaviour
{
    public string tagPrato;
    
    void OnCollisionEnter2D(Collision2D other)
    {
        print(gameObject.tag);
        print(tagPrato);
        if (gameObject.tag == other.gameObject.tag)
        {
            print("prato certo");
            other.gameObject.transform.position = new Vector2(-24.4f,2.9f);
            other.gameObject.GetComponent<Alimento>().destroiObjeto();
            InfoUI.pontos = InfoUI.pontos +1;
        }
        else if (other.gameObject.tag != "Player" && other.gameObject.tag != gameObject.tag) 
        {
            print("prato errado");
            other.gameObject.GetComponent<Alimento>().destroiObjeto();
        }
    }
}
