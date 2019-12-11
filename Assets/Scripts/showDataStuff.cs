using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showDataStuff : MonoBehaviour
{
    public Text slidervalue;
    public Text slider2value;
    public Text Score;
   
    

    void Awake()
    {
      
        slidervalue.text = "Size: " + dataStuff.slidertext;
        slider2value.text = "Speed: " + dataStuff.slidertext2;
        Score.text = "Name: " + dataStuff.name + " \n" + "Your score was: " + ScoreKeeper.newScore + "\n" +
        "You had " + LivesTracker.lives + " lives";
    }
}
