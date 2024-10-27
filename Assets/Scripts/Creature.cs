using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    Rigidbody2D rb;

    [Header("Movement")]
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float smooth = 50.0f; // Smoothly tilts a transform towards a target rotation.
    float yRotation; // 180 left, 0 right
    Quaternion target; // target direction to turn

    [Header("Jump")]
    [SerializeField] int jumpPower = 15;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;
    bool isGrounded;

    /**
    * function: Awake()
    * args: None
    * description: Get the Creature's rigidbody 2D
    */
    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    /**
    * function: Move()
    * args:
    * - float direction: -1 left, 1 right
    * description: moves the creature to left or right
    */
    public void Move(float direction)
    {
        rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);

        if(direction == -1){
            // turn left
            yRotation = 180f;
        }
        else{
            // turn right
            yRotation = 0f;
        }
        
        flipDirection(yRotation);        
    }

    void flipDirection(float yRotation)
    {
        // Rotate the object by converting the angles into a quaternion.
        target = Quaternion.Euler(0f, yRotation, 0f);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }

    public void Jump()
    {

        // TODO: Add constraint to only jump when on the ground
        // isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(1.8f, 0.3f), CapsuleDirection2D.Horizontal, 0, groundLayer);
        
        // if(isGrounded)
        // {
        //     Debug.Log("Grounded and Jumping");
        //     rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        // }
        
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
    }
        
}

