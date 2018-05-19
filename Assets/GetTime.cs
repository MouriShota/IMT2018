using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GetTime : MonoBehaviour {
    private GameObject timerText;
    // Use this for initialization
    void Start () {
        timerText = GameObject.Find("TimerText");
    }
	
	// Update is called once per frame
	void Update () {
        int y = DateTime.Now.Year;
        int d = DateTime.Now.Day;
        int h = DateTime.Now.Hour;
        int m = DateTime.Now.Minute;
        int s = DateTime.Now.Millisecond;

        
        timerText.GetComponent<Text>().text = DateTime.Now.ToString("yyyy年MM月dd日hh時mm分ss秒");
    }
}
