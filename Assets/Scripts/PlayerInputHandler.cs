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
    [SerializeField] Sheriff playerSheriff;

    /**
    * function: FixedUpdate()
    * args: None
    * description: Grabs player input and moves the alien accordingly
    */
    void FixedUpdate(){

        // Move Left:
        if (Input.GetKey(KeyCode.A))
        {
            playerSheriff.Move(direction: -1);
        }

        // Move Right:
        if (Input.GetKey(KeyCode.D))
        {
            playerSheriff.Move(direction: 1);
        }
        
    }

    void Update() 
    {
        // Jump:
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerSheriff.Jump();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerSheriff.GetProjectileLauncher().Launch();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            playerSheriff.GetProjectileLauncher().Reload();
        }
    }
    
}
