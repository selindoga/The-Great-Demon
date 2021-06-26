using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 60;
    public TextMeshProUGUI DisplayedTime;
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            time = 0;
        }
        ShowTime(time);
    }

    void ShowTime(float theTime)
    {
        if (theTime < 0)
        {
            theTime = 0;
        }

        float min = Mathf.FloorToInt(theTime / 60);
        float sec = Mathf.FloorToInt(theTime % 60);
        DisplayedTime.text = string.Format("{0:00}m{1:00}s", min, sec);

    }
}
