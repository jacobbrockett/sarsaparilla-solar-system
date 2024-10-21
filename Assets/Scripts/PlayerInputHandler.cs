using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

/**
* class: PlayerInputHandler
* description: Class is responsible for handling player inputs, such as movement
*/
public class PlayerInputHandler : MonoBehaviour
{
    [Header("Sprites")]
    [SerializeField] Alien playerAlien;

    /**
    * function: FixedUpdate()
    * args: None
    * description: Grabs player input and moves the alien accordingly
    */
    void FixedUpdate(){
        // Initialize Vector3:
        Vector3 movement = Vector3.zero;

        // Move Left:
        if (Input.GetKey(KeyCode.A))
        {
            movement += new Vector3(-1, 0, 0);
        }

        // Move Right:
        if (Input.GetKey(KeyCode.D))
        {
            movement += new Vector3(1, 0, 0);
        }

        // Move player alien:
        playerAlien.Move(movement);
    }

    void Update() 
    {
        // Jump:
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerAlien.Jump();
        }
    }
    
}
