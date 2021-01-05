using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Vector2 movement;
    public bool isShooting;
   
    
        public void OnMoveInput(InputAction.CallbackContext context)
        {
            movement = context.ReadValue<Vector2>();
        }

        public void OnShootInput(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                isShooting = true;
            }
            else if (context.canceled)
            {
                isShooting = false;
            }
        }
        
        
        
}
