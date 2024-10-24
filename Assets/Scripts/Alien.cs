using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    Rigidbody2D rb;

    [Header("Movement")]
    [SerializeField] float speed = 5f;
    [SerializeField] int jumpForce = 15;

    /**
    * function: Awake()
    * args: None
    * description: Get the Alien's rigidbody 2D
    */
    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    /**
    * function: Move()
    * args:
    * - Vector3 movement: position to move the Spaceship to
    * description: moves the Spaceship to a position passed as a parameter
    */
    public void Move(Vector3 movement)
    {
        rb.MovePosition(transform.position + (movement * speed) * Time.fixedDeltaTime); // add position to current position
    }

    // void FixedUpdate(){
    //     if(Input.GetButtonDown("Jump"))
    //     {
    //         Debug.Log("Jump");
    //         rb.AddForce(transform.up * jumpForce);
    //         // rb.AddForce(new Vector2(0,jumpForce) - rb.velocity);
    //     }
    // }

    // public void Jump()
    // {
    //     rb.AddForce(transform.up * jumpForce);        
        
    //     // rb.velocity = new Vector2(rb.velocity.x, 400f * Time.fixedDeltaTime * 100);  // Set vertical velocity directly for smooth jump
        
    //     // Vector3 movement = new Vector3 (0, 1, 0);
    //     // rb.MovePosition(transform.position + (movement * speed) * Time.fixedDeltaTime); // add position to current position

    
    // }

    // public Rigidbody2D GetRigidBody()
    // {
    //     return rb;
    // }
}
