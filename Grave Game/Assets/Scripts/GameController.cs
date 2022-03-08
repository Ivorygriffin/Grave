using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    private float _remainingTime;
    public float timePerHour;
    public int hoursPerRound;
    private int _currentHour;
    public TMP_Text timeText;



    void Start()
    {
        timePerHour = _remainingTime;
    }

   
    void Update()
    {
        Timer();
    }

    public void Timer()
    {
        _remainingTime -= Time.deltaTime;
        if(_remainingTime <= 0)
        {
            _currentHour += 1;
            _remainingTime = timePerHour;
        }
       if(_currentHour == 0)
        {
            timeText.text = "12:00AM";
        }
       if(_currentHour == 1)
        {
            timeText.text = "1:00AM";
        }  
        if(_currentHour == 2)
        {
            timeText.text = "2:00AM";
        }
        if(_currentHour == 3)
        {
            timeText.text = "3:00AM";
        } 
        if(_currentHour == 4)
        {
            timeText.text = "4:00AM";
        } 
        if(_currentHour == 5)
        {
            timeText.text = "5:00AM";
        }
        if(_currentHour == hoursPerRound)
        {
            EndRound();
        }


    }

    public void EndRound()
    {

    }


}
