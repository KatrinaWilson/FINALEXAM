using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
   
   
    public Text timeLimitText;
    public Text remainingTimeText;
   

    public float timelimit;
    public float timeRemaining;

    // Start is called before the first frame update
    
    void Start()
    {
       
        if (dataStuff.MyChoice1)
            timelimit = 30f;
        else
        if (dataStuff.MyChoice2)
            timelimit = 60f;
        else
        if (dataStuff.MyChoice3)
            timelimit = 120f;

        timeRemaining = timelimit;


        timeLimitText.text = "time limit: " + timelimit.ToString("F2");
        remainingTimeText.text = "time remaining: " + timeRemaining.ToString("F2");
    }


    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            remainingTimeText.text = "time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            remainingTimeText.text = "game over";
        }

    }
}
