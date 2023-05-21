using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alimento : MonoBehaviour
{
    public GameObject alimentoNovo;

    public void destroiObjeto() {
        Destroy(gameObject);
        StartCoroutine(SpawnaAlimento());
    }

    
    IEnumerator SpawnaAlimento()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(7f);

        if(gameObject.tag == "frango")
        {
            Instantiate(alimentoNovo, new Vector3(19.75f,3.38f), Quaternion.identity);
        }
    }
}
