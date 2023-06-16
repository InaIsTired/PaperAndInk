using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver3 : MonoBehaviour
{
    public void ToMainMenu()
    {
        SceneManager.LoadScene("Intro Screen");
    }
    public void Retry()
    {
        SceneManager.LoadScene("Level3");
    }
}
