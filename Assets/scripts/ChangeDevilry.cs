using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeDevilry : MonoBehaviour
{
    public CollectAngels Devilryness;
    
    public TextMeshProUGUI level;

    //void Start()
    //{
        //Devilryness.level = GetComponent<TextMeshProUGUI>();
    //}

    private void Awake()
    {
        Devilryness = GetComponent<CollectAngels>();
    }

    void Update()
    {
        Check();
    }

    public void Check()
    {
        if (Devilryness.devilryLevel == 3)
        {
            level.text = "Real Demon!";
        }
        else if (Devilryness.devilryLevel == 2)
        {
            level.text = "Looks like a fake demon..";
        }
        else if (Devilryness.devilryLevel == 1)
        {
            level.text = "Your devilry is Fake!";
        }else if (Devilryness.devilryLevel <= 0)
        {
            level.text = "You are too good to win!";
        }
    }
}
