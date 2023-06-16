using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Retry3 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            SceneManager.LoadScene("Level3");
        }
    }
}
