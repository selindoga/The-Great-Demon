using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float positionX = 0f;
   

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (transform.position.x == 0f)
        {
            if (Input.GetKeyDown("left"))
            {
                positionX = -3.3f;
                MoveTo();
            }
            else if (Input.GetKeyDown("right"))
            {
                positionX = 3.3f;
                MoveTo();
            }
        }

        else if (transform.position.x == -3.3f)
        {
            if (Input.GetKeyDown("right"))
            {
                positionX = 0f;
                MoveTo();
            }
        }

        else if (transform.position.x == 3.3f)
        {
            if (Input.GetKeyDown("left"))
            {
                positionX = 0f;
                MoveTo();
            }

        }
    }

    void MoveTo()
    {
        Vector2 temp = new Vector2(positionX, gameObject.transform.position.y);
        transform.position = temp;
        positionX = transform.position.x;
        //checkPosition();
    }
    // public void checkPosition()
    // {
    //     positionX = transform.position.x;
        // if (positionX == 0f)
        // {
        //     atLastLeft = false;
        //     atLastRight = false;
        // }
        // else if(positionX == -3.3f)
        // {
        //     atLastLeft = true;
        //     atLastRight = false;
        // }
        // else if(positionX == 3.3f)
        // {
        //     atLastLeft = false;
        //     atLastRight = true;
        // }
    // }
}
