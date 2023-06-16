using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechB : MonoBehaviour
{
    public GameObject SwitchB;
    public GameObject SwitchB2;
    public GameObject ObstacleW;
    public GameObject ObstacleB;
    public GameObject ObstacleW2;
    public GameObject ObstacleB2;
    public float a;
    public float b;
    public float e;
    public float f;
    public GameObject WinKey2;
    // Start is called before the first frame update
    void Start()
    {
        SwitchB = GameObject.FindGameObjectWithTag("SwitchB");
        ObstacleB = GameObject.Find("ObstacleB");
        ObstacleW = GameObject.Find("ObstacleW");
        SwitchB2 = GameObject.FindGameObjectWithTag("SwitchB2");
        ObstacleB2 = GameObject.Find("ObstacleB2");
        ObstacleW2 = GameObject.Find("ObstacleW2");
        WinKey2 = GameObject.Find("WinKey2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "SwitchB")
        {
            MoveW(a, b);
        }
        if (coll.gameObject.tag == "SwitchB2")
        {
            MoveW2(e, f);
        }
        if (coll.gameObject.tag == "WinB")
        {
            WinKey2.SetActive(false);
        }

    }
    void MoveW(float a, float b)
    {
        ObstacleW.transform.position = new Vector3(a, b, 0);
        SwitchB.SetActive(false);
    }
    void MoveW2(float e, float f)
    {
        ObstacleW2.transform.position = new Vector3(e, f, 0);
        SwitchB2.SetActive(false);
    }
}
