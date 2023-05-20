using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntregaPrato : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (gameObject.tag == other.gameObject.tag)
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag != "Player" && other.gameObject.tag != gameObject.tag) 
        {
            Destroy(other.gameObject);
        }
    }
}
