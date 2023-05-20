using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ferramenta : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        // print(transform.position);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject);
        if (gameObject.tag == "Fritadeira" && collision.gameObject.tag == "frango")
        {
            Destroy(collision.gameObject);
            spriteRenderer.sprite = newSprite; 
        }
    }
    
}
