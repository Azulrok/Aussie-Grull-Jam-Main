using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ferramenta : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public GameObject alimentoPronto;
    
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
            StartCoroutine(FritaAlimento());
        }
    }

    IEnumerator FritaAlimento()
    {
        //Print the time of when the function is first called. color red
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.5f);

        Instantiate(alimentoPronto, transform.position, Quaternion.identity);

        //After we have waited seconds print the time again. color blue
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        
        yield return new WaitForSeconds(0.5f);
        
    }
    
}
