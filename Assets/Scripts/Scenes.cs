using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void IntroScene()
    {
        SceneManager.LoadScene("1Intro");
    }
    public void NextScene()
    {
        SceneManager.LoadScene("2HighScores");
    }
    public void StopPlay()
    {
        SceneManager.LoadScene("4Exit");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("3Game");
    }
    public void ExitGame()
    {

        UnityEditor.EditorApplication.isPlaying = false;
    }
}
