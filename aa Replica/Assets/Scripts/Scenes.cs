using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{


   public void StartPlay()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }

    public void ExitGame()
    {
 
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
