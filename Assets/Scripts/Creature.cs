using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    Rigidbody2D rb;

    [Header("Movement")]
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] int jumpPower = 15;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;
    bool isGrounded;


    // Smoothly tilts a transform towards a target rotation.
    [SerializeField] float smooth = 5.0f;
    float yRotation;
    Quaternion target;

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
    * - Vector3 movement: position to move the creature to
    * description: moves the creature to a position passed as a parameter
    */
    public void Move(Vector3 movement)
    {
        rb.MovePosition(transform.position + (movement * moveSpeed) * Time.fixedDeltaTime); // add position to current position
    }

    public void MoveLeft()
    {
        rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);

        // If flipY is true, rotate by 180 degrees on the Y-axis
        yRotation = 180f;

        // Rotate the object by converting the angles into a quaternion.
        target = Quaternion.Euler(0f, yRotation, 0f);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    
    }

    public void MoveRight()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        // If flipY is true, rotate by 180 degrees on the Y-axis
        yRotation = 0f;

        // Rotate the object by converting the angles into a quaternion.
        target = Quaternion.Euler(0f, yRotation, 0f);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }

    public void Jump()
    {
        // isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(1.8f, 0.3f), CapsuleDirection2D.Horizontal, 0, groundLayer);
        
        // if(isGrounded)
        // {
        //     Debug.Log("Grounded and Jumping");
        //     rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        // }
        
        // TODO: Add constraint to only jump when on the ground
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
    }
        
}

