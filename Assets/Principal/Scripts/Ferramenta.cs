using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ferramenta : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public GameObject alimentoPronto;
    private bool destroy = false;
    private GameObject instantiatedObject; 
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        print(other.gameObject);
        if (gameObject.tag == other.gameObject.tag)
        {
            Destroy(other.gameObject);
            spriteRenderer.sprite = newSprite; 
            StartCoroutine(FritaAlimento());
            destroy = true;
        }
        else if (other.gameObject.tag !=  "Player" && other.gameObject.tag != "frangoFrito") 
        {
            Destroy(other.gameObject);
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == alimentoPronto.tag)
        {
            destroy = false;
        }
    }



    IEnumerator FritaAlimento()
    {
        //Print the time of when the function is first called. color red
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2f);

        instantiatedObject = Instantiate(alimentoPronto, transform.position, Quaternion.identity);

        //After we have waited seconds print the time again. color blue
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        
        yield return new WaitForSeconds(5f);

        if (destroy)
        {
            Destroy(instantiatedObject);
        }
        
    }
    
}
