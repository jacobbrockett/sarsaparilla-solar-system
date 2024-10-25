using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.Audio;

/**
* class: PlayerInputHandler
* description: Class is responsible for handling player inputs, such as movement
*/
public class PlayerInputHandler : MonoBehaviour
{
    [Header("Sprites")]
    [SerializeField] Creature playerCreature;

    Vector3 movement;

    /**
    * function: FixedUpdate()
    * args: None
    * description: Grabs player input and moves the alien accordingly
    */
    void FixedUpdate(){
        movement = Vector3.zero;

        // Move Left:
        if (Input.GetKey(KeyCode.A))
        {
            movement += new Vector3(-1, 0, 0);
            // Move player alien:
            // playerCreature.Move(movement);
            playerCreature.MoveLeft();
        }

        // Move Right:
        if (Input.GetKey(KeyCode.D))
        {
            movement += new Vector3(1, 0, 0);
            // Move player alien:
            // playerCreature.Move(movement);
            playerCreature.MoveRight();
        }

        // // Jump:
        // if (Input.GetKeyDown(KeyCode.W))
        // {
        //     playerCreature.Jump();
        // }
        
    }

    void Update() 
    {
        // Jump:
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerCreature.Jump();
        }
    }
    
}
