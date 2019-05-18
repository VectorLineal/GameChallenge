using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public long seconds=30600;
    private int timer=4;
    string clockString="";
    public Text text;
    private long[] printClock() {
        long minutes = seconds / 60, hours=minutes/60;
        long[] clock = new long[2];

        clock[0] = hours%24;
        clock[1] = minutes % 60;

        return clock;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        long[] clock = printClock();
        if (clock[0] < 10 && clock[1] < 10)
        {
            clockString = "0" + clock[0] + ":0" + clock[1] + "hrs";
        }
        else if (clock[0] < 10 && clock[1] >= 10)
        {
            clockString = "0" + clock[0] + ":" + clock[1] + "hrs";
        }
        else if (clock[0] >= 10 && clock[1] < 10)
        {
            clockString = clock[0] + ":0" + clock[1] + "hrs";
        }
        else {
            clockString = clock[0] + ":" + clock[1] + "hrs";
        }
        text.text = clockString;
        if (timer >= 4)
        {
            seconds++;
        }
        timer--;

        if (timer <= 0) { timer = 4; }
    }
}
