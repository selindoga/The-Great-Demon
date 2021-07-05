using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeDevilry : MonoBehaviour
{
    public int devilryLevel = 3;
    
    
    public TextMeshProUGUI level;

    //void Start()
    //{
        //Devilryness.level = GetComponent<TextMeshProUGUI>();
    //}

    

    void Update()
    {
        Check();
    }

    public void Check()
    {
        if (devilryLevel == 3)
        {
            level.text = "Real Demon!";
        }
        else if (devilryLevel == 2)
        {
            level.text = "Looks like a fake demon..";
        }
        else if (devilryLevel == 1)
        {
            level.text = "Your devilry is Fake!";
        }else if (devilryLevel <= 0)
        {
            level.text = "You are too good to win!";
        }
    }
}
