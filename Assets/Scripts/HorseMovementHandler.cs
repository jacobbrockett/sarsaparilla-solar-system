using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseMovementHandler : MonoBehaviour
{
    [Header("Sprites")]
    [SerializeField] Creature playerCreature;

    bool finished = false;

    /**
    * function: FixedUpdate()
    * args: None
    * description: Grabs player input and moves the alien accordingly
    */
    void FixedUpdate(){
        if (!finished)
        {
            // Move right continuously
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

    public void Finished()
    {
        finished = true;
    }
}
