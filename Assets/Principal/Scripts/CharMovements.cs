using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovements : MonoBehaviour
{
    private float moveSpeed = 5f;

    private Rigidbody2D rb;
    // private Animator animator;

    Vector2 movement;
    private PickUp pickUp;
    
    void Start() {
        rb = gameObject.GetComponent<Rigidbody2D>();
        // animator = gameObject.GetComponent<Animator>();
        pickUp = gameObject.GetComponent<PickUp>();
        pickUp.Direction = new Vector2(movement.x, movement.y);
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        if (movement.sqrMagnitude > .1f)
        {
            pickUp.Direction = movement.normalized;
        }

        // animator.SetFloat("Horizontal", movement.x);
        // animator.SetFloat("Vertical", movement.y);
        // animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    void FixedUpdate ()
    {
         rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }




//     public float speed;

//     public void Update()
//     {
//         Movement();
//     }
//     private void Movement()
//     {
//         if (Input.GetKey(KeyCode.W))
//         {
//             transform.position += transform.up * speed * Time.deltaTime;
//         }
//         if (Input.GetKey(KeyCode.S))
//         {
//             transform.position -= transform.up * speed * Time.deltaTime;
//         }
//         if (Input.GetKey(KeyCode.D))
//         {
//             transform.position += transform.right * speed * Time.deltaTime;
//         }
//         if (Input.GetKey(KeyCode.A))
//         {
//             transform.position -= transform.right * speed * Time.deltaTime;
//         }
//     }
}
