using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInArea : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Angel")) // to destroy the angels even tho there are only angels :D
        {
            Destroy(other.gameObject);
        }
    }
}
