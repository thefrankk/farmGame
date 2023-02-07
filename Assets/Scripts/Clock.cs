using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    public TMP_Text clockText;
    public float seconds, minutes, hours;

    private void Update()
    {
        DisplayTime();
    }

    void DisplayTime()
    {
        seconds++;
        if (seconds >= 60)
        {
            minutes++;
            seconds = 0;
        }
        if (minutes >= 60)
        {
            hours++;
            minutes = 0;
        }
        if (hours >= 24)
        {
            seconds = 0;
            minutes = 0;
            hours = 0;
        }
        clockText.text = string.Format("{0:00}:{1:00}", hours, minutes);
    }
}
