using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Win_MainMenu : MonoBehaviour
{
    public void ToMainMenu()
    {
        SceneManager.LoadScene("Intro Screen");
    }
}
