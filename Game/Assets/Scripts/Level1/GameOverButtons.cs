using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{
    public void ToMainMenu()
    {
        SceneManager.LoadScene("Intro Screen");
    }
    public void Retry()
    {
        SceneManager.LoadScene("Level1");
    }
}
