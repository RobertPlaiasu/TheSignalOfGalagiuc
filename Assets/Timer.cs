using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float time = 0;
    
    void Update()
    {
        time += Time.deltaTime;
        text.text = FormatTime(time);
    }

    string FormatTime(float time)
    {
        float minutes = Mathf.Floor(Mathf.Floor(time) / 60);
        float seconds = Mathf.Floor(time) % 60;
        string timeString = "";

        if (minutes < 10) timeString += "0";
        timeString += minutes.ToString();
        
        timeString += ":";
        
        if (seconds < 10) timeString += "0";
        timeString += seconds.ToString();

        return timeString;
    }
}
