﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] 
    private float xSpeed = 10f;

    [SerializeField] private GameObject[] guns;

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
        Shoot();

    }


    private void Shoot()
    {
        if (playerController.isShooting)
        {
            foreach (var gun in guns)
            {
                gun.SetActive(true);
            }
        }
        else
        {
            foreach (var gun in guns)
            {
                gun.SetActive(false);
            }
        }
    }
    
    
    private void Move()
    {
        xOffset = xSpeed * playerController.movement.x * Time.deltaTime;
        yOffset = ySpeed * playerController.movement.y * Time.deltaTime;
        yOffset = Mathf.Clamp(yOffset + transform.localPosition.y, -3, 3);
        xOffset = Mathf.Clamp(xOffset + transform.localPosition.x, -5, 5);
        transform.localPosition = new Vector3(xOffset , yOffset , transform.localPosition.z);
    }

    private float yRot,yR;
    private void Rotate()
    {
        yRot = playerController.movement.x * -1 ;
        yR = Mathf.Clamp( yR + yRot + transform.localRotation.y , -15, 15);
        
        Quaternion y = Quaternion.Euler(transform.localPosition.y * -10 + playerController.movement.y * -7 , transform.localPosition.x * 12 , yRot*20);
        transform.localRotation = y;



    }


    private void KillTheControls()
    {
        
        GetComponent<PlayerInput>().currentActionMap = null;
        
    }
}
