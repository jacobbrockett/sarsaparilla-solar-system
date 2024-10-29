using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.Audio;

/**
* class: PlayerInputHandler
* description: Class is responsible for handling player inputs, such as movement
*/
public class SheriffMovementHandler : MonoBehaviour
{
    [Header("Sprites")]
    [SerializeField] Creature playerCreature;

    /**
    * function: FixedUpdate()
    * args: None
    * description: Grabs player input and moves the alien accordingly
    */
    void FixedUpdate(){

        // Move Left:
        if (Input.GetKey(KeyCode.A))
        {
            playerCreature.Move(direction: -1);
        }

        // Move Right:
        if (Input.GetKey(KeyCode.D))
        {
            playerCreature.Move(direction: 1);
        }
        
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
