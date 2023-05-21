using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class CharMovements : MonoBehaviour
{
    private float moveSpeed = 5f;

    public GameObject[] anims;
  
    private Rigidbody2D rb;
    // private Animator animator;

    Vector2 movement;
    private PickUp pickUp;
    
    void Start() 
    {      
        rb = gameObject.GetComponent<Rigidbody2D>();
        // animator = gameObject.GetComponent<Animator>();
        pickUp = gameObject.GetComponent<PickUp>();
        pickUp.Direction = new Vector2(movement.x, movement.y);
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        Movement();

        if (movement.sqrMagnitude > .1f)
        {
            pickUp.Direction = movement.normalized;
        }
    }
    // void FixedUpdate ()
    // {
    //      rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    // }

    public float speed;  
    
    private void Movement()
     {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * speed * Time.deltaTime;
            anims[0].SetActive(false);
            anims[1].SetActive(false);
            anims[2].SetActive(true);
            anims[1].transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
         {
            transform.position -= transform.up * speed * Time.deltaTime;
            anims[0].SetActive(true);
            anims[1].SetActive(false);
            anims[2].SetActive(false);
            anims[1].transform.rotation = Quaternion.Euler(0f, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
         {
             transform.position += transform.right * speed * Time.deltaTime;
             anims[0].SetActive(false);
             anims[1].SetActive(true);
             anims[2].SetActive(false);
             anims[1].transform.rotation = Quaternion.Euler(0f, 0f, 0f);

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
         {
             transform.position -= transform.right * speed * Time.deltaTime;
             anims[0].SetActive(false);
             anims[1].SetActive(true);
             anims[2].SetActive(false);
             anims[1].transform.rotation = Quaternion.Euler(0f, -180f, 0f);

        }
    }
}
