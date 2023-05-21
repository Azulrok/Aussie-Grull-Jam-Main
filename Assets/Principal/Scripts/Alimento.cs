using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Alimento : MonoBehaviour
{
    public GameObject alimentoNovo;
    private GameObject instantiatedObject; 
    public float posX;
    public float posY;

    public void destroiObjeto() {
        
        StartCoroutine(SpawnaAlimento());
    }

    
    IEnumerator SpawnaAlimento()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3f);

        
            Destroy(gameObject);
            
            instantiatedObject = Instantiate(alimentoNovo, new Vector3(posX, posY), Quaternion.identity);
            
            BoxCollider2D boxCollider = instantiatedObject.GetComponent<BoxCollider2D>();
            boxCollider.enabled = true;
        
    }
}
// 19.75f,3.38f