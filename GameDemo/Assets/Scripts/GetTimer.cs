﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTimer : MonoBehaviour
{
    public Text TimerBox;
    // Start is called before the first frame update
    void Start()
    {
      Timer.timerActive = false;
      TimerBox.text = Timer.timeStart.ToString("F2"); 
      Timer.timeStart = 0;
    }

    // Update is called once per frame
    void Update()
    {

      //TimerBox.text = Timer.timeStart.ToString("F2");       
    }
}
