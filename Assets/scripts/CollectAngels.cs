using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectAngels : MonoBehaviour
{
    public int devilryLevel = 3;

    // public void Start()
    // {
    //     //level = GetComponent<TextMeshProUGUI>();
    // }

    // public void Update()
    // {
    //     //ChangeDevilryLevel();
    // }

    public void FixedUpdate()
    {
        transform.Translate(0, -3f  * Time.deltaTime,0);
    }
    public void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            devilryLevel--;
            Destroy(gameObject);
        } else if (other.CompareTag("DestroyArea"))
        {
            Destroy(gameObject);
        }
    }

    // public void ChangeDevilryLevel()
    // {
    //     if (devilryLevel == 3)
    //     {
    //         level.text = "Real Demon!";
    //     }
    //     else if (devilryLevel == 2)
    //     {
    //         level.text = "Looks like a fake demon..";
    //     }
    //     else if (devilryLevel == 1)
    //     {
    //         level.text = "Your devilry is Fake!";
    //     }else if (devilryLevel <= 0)
    //     {
    //         level.text = "You are too good to win!";
    //     }
    // }
}
