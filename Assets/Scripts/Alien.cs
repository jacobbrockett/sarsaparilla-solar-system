using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    Rigidbody2D rb;

    [Header("Movement")]
    [SerializeField] float speed = 5f;

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
}
