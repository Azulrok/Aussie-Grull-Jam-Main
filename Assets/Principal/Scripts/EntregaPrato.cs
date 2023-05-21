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
        if (gameObject.tag == tagPrato)
        {
            print("prato certo");
            Destroy(other.gameObject);
            other.gameObject.GetComponent<Alimento>().destroiObjeto();
        }
        else if (other.gameObject.tag != "Player" && other.gameObject.tag != gameObject.tag) 
        {
            print("prato errado");
            other.gameObject.GetComponent<Alimento>().destroiObjeto();
        }
    }
}
