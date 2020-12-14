using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] 
    private float xSpeed = 10f;

    private float ySpeed = 8f;
    


    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
    }

    private float xOffset;
    private float yOffset;

    private void Update()
    {
        
        Move();
        Rotate();     
                    
    }

    
    
    
    
    private void Move()
    {
        xOffset = xSpeed * playerController.movement.x * Time.deltaTime;
        yOffset = ySpeed * playerController.movement.y * Time.deltaTime;
        yOffset = Mathf.Clamp(yOffset + transform.localPosition.y, -2, 2);
        xOffset = Mathf.Clamp(xOffset + transform.localPosition.x, -3, 3);
        transform.localPosition = new Vector3(xOffset , yOffset , transform.localPosition.z);
    }

    private float yRot,yR;
    private void Rotate()
    {
        yRot = playerController.movement.x * -1 ;
        yR = Mathf.Clamp( yR + yRot + transform.localRotation.y , -15, 15);
        
        Quaternion y = Quaternion.Euler(transform.localPosition.y * -15 + playerController.movement.y * 7 , transform.localPosition.x * 10 , 0);
        transform.localRotation = y;



    }
}
