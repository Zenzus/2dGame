using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{


    public Text timerText;
    private float timer = 0f;
    bool win = false;
    public float wintime;


    void Update()
    {
        if (win == false) {
            timer += Time.deltaTime;

            timerText.text = "Time: " + System.Math.Round(timer, 2);
            wintime = timer;
        }
        if (win == true)
        {
            wintime = timer;
            timerText.text = "Time: " + System.Math.Round(wintime, 2);
            SaveTime();
        }
        
    }

    public void setWinTime()
    {
        win = true;
    }

    public void SaveTime()
    {
        GlobalControl.Instance.wintime = wintime;
        
    }
}
