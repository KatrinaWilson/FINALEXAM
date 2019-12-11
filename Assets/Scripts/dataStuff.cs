using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dataStuff : MonoBehaviour
{

    public Dropdown timechoice;
    public Text MyChoice;
    public static Text MyChoice1;
    public static Text MyChoice2;
    public static Text MyChoice3;


    public Slider slider;
    public Slider slider2;
    public static Text slidertext;
    public static Text slidertext2;
    public static float slidervalue2 = 1f;
    public static float slidervalue = 1f;
    public InputField player;
    public static string name;
    public Text namee;
    // Update is called once per frame
    public void ShowChoice()
    {
        switch (timechoice.value)
        {
            case 1:
                MyChoice.text = "Please Select a time";
                break;
            case 2:
                MyChoice1.text = "30";
                break;
            case 3:
                MyChoice2.text = "60";
                break;
            default:
                MyChoice3.text = "120";
                break;
        }
    }

    public void Update() //method for the slider on intro screen
    {

        name = player.text;
        namee.text = name;

        slidervalue = slider.value;
        slidertext.text = slidervalue.ToString();
        Debug.Log(slidervalue);

        slidervalue2 = slider2.value;
        slidertext2.text = slidervalue2.ToString();
        Debug.Log(slidervalue2);
    }
}