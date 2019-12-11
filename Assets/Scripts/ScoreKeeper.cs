using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreKeeper : MonoBehaviour
{
    static public int newScore = 0;
    public static string PlayerName;
    static public InputField playerNamee;
    public Text NewScore;
    public Text playerName;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }

    public void Update()
    {
        PlayerName = playerNamee.text;
        playerName.text = PlayerName;
    }
    public void IncreaseScore() // clicking on + button increases score
    {
        newScore += 1;
        NewScore.text = newScore.ToString();
        Debug.Log(newScore);
    }

    public void DecreaseScore() // clicking on - button decreases score
    {
        newScore -= 1;
        NewScore.text = newScore.ToString();
        Debug.Log(newScore);
    }
 
}
