
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winTime : MonoBehaviour
{
    public Text timerText;
  
    private float wintime;
    // Start is called before the first frame update
   

        void Start()
        {
         wintime = GlobalControl.Instance.wintime;
            
        
        
        timerText.text = "Time: " + wintime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
