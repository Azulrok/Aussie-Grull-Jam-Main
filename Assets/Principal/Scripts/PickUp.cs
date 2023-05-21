using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform holdSpot;
    public LayerMask pickUpMask;
    // public GameObject destroyEffect;
    public Vector3 Direction { get; set; }
    private GameObject itemHolding;
    private bool emMaos = false;

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(itemHolding)
            {
                itemHolding.transform.position = transform.position + Direction;
                itemHolding.transform.parent = null;
                if (itemHolding.GetComponent<Rigidbody2D>())
                        itemHolding.GetComponent<Rigidbody2D>().simulated = true;
                itemHolding.GetComponent<Alimento>().destroiObjeto();
                itemHolding = null;
            }
            else
            {   //position + direcao do personagem magnitude = 1, radious, mask
                Collider2D pickUpItem = Physics2D.OverlapCircle(transform.position + Direction, .12f, pickUpMask);
                if (pickUpItem)
                {
                    itemHolding = pickUpItem.gameObject;
                    itemHolding.transform.position = holdSpot.position;
                    itemHolding.transform.parent = transform;
                    if (itemHolding.GetComponent<Rigidbody2D>())
                        itemHolding.GetComponent<Rigidbody2D>().simulated = false;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (itemHolding)
            {
                StartCoroutine(ThrowItem(itemHolding));
                itemHolding = null;
            }
        }
    }

    IEnumerator ThrowItem(GameObject item)
    {
        Vector3 startPoint = item.transform.position;
        Vector3 endPoint = transform.position + Direction * 5;
        item.transform.parent = null;
        for (int i = 0; i < 50; i++)
        {
            item.transform.position = Vector3.Lerp(startPoint, endPoint, i * .02f); // 0.4 = 1/25
            yield return null;
        }
        if (item.GetComponent<Rigidbody2D>())
            item.GetComponent<Rigidbody2D>().simulated = true;
        item.GetComponent<Alimento>().destroiObjeto();
        item = null;
        // Instantiate(destroyEffect, item.transform.position, Quaternion.identity);
        // Destroy(item);
    }
}
