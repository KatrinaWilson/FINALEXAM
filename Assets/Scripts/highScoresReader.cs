using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class highScoresReader : MonoBehaviour
{
    public Text highScoreDisplay;
    private static string[] highScoreList;
    string wordList;
    // Start is called before the first frame update
    void Start()
    {
        highScoreList = File.ReadAllLines("Assets/scores.txt");
        wordList = highScoreList[0] + "\n" + highScoreList[1] + "\n" + highScoreList[2];
        highScoreDisplay.text = wordList;
    }

}
