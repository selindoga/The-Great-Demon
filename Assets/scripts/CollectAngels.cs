using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectAngels : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Translate(0, -3f  * Time.deltaTime,0);
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<ChangeDevilry>().DecreaseDevilryLevel();
            Destroy(gameObject);
        } 
        else if (other.CompareTag("DestroyArea"))
        {
            Destroy(gameObject);
        }
    }
}
