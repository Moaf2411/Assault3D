using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField] 
    private float xSpeed = 4f;


    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
    }


    private void Update()
    {
            float xOffset = xSpeed * playerController.movement.x * Time.deltaTime;
            xOffset = Mathf.Clamp(xOffset + transform.localPosition.x, -3, 3);
            transform.localPosition = new Vector3(xOffset , transform.localPosition.y , transform.localPosition.z);
    }
}
