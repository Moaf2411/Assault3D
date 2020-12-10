using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Vector2 movement;
    
   
    
        public void OnMoveInput(InputAction.CallbackContext context)
        {
            movement = context.ReadValue<Vector2>();
        }
        
        
        
}
