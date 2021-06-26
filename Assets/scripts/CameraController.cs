using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController: MonoBehaviour
{
    public Transform player;
    private Vector3 targetPosition;
    public GameObject PlayerObject;
    private float movingSpeed = 5f;
    
    void FixedUpdate()
    {
        ChangePlayerMovement();
        targetPosition = new Vector3(0, player.position.y + 6f, -10);
        transform.position = targetPosition;
    }
    
    void ChangePlayerMovement()
    {
        if (Input.GetKey("left"))
        {
            PlayerObject.transform.Translate(Vector2.left * (movingSpeed * Time.deltaTime));
        }else if (Input.GetKey("right"))
        {
            PlayerObject.transform.Translate(Vector2.right * (movingSpeed * Time.deltaTime));
        }else if (Input.GetKey("up"))
        {
            PlayerObject.transform.Translate(Vector2.up * (movingSpeed * Time.deltaTime));
        }
    }

    
}
