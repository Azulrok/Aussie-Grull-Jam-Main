using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comandas : MonoBehaviour
{
    public Sprite frangoFrito;
    public Sprite hamburguero;
    public Sprite cookie;
    public int id;

    private Image spriteRenderer;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<Image>();
        StartCoroutine(GeraCommanda());
    }

    IEnumerator GeraCommanda()
    {
        yield return new WaitForSeconds(1.5f);
        
        if (id == 1)
            spriteRenderer.sprite = frangoFrito;

        yield return new WaitForSeconds(7f);

        if (id == 2)
            spriteRenderer.sprite = hamburguero;

        yield return new WaitForSeconds(15f);
        
        if (id == 3)
            spriteRenderer.sprite = cookie;      
    }

}
