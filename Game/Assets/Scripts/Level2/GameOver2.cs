using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver2 : MonoBehaviour
{
    public void ToMainMenu()
    {
        SceneManager.LoadScene("Intro Screen");
    }
    public void Retry()
    {
        SceneManager.LoadScene("Level2");
    }
}
