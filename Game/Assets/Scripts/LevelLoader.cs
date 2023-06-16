using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    //public GameObject Player1;
    //public GameObject Player2;
    public GameObject WinKey1;
    public GameObject WinKey2;
    // Update is called once per frame
    void Start()
    {
        WinKey1 = GameObject.Find("WinKey1");
        WinKey2 = GameObject.Find("WinKey2");
    }
    void Update()
    {
        if (WinKey1.activeSelf == false && WinKey2.activeSelf == false)
        {
            LoadNextLevel();
        }
    }
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
    
}
