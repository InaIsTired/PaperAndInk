using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechB2 : MonoBehaviour
{
    public GameObject SwitchB;
    public GameObject SwitchB2;
    public GameObject SwitchB3;
    public GameObject SwitchB4;
    public GameObject SwitchB5;
    public GameObject SwitchB6;
    public GameObject ObstacleW;
    public GameObject WinKey2;
    public float a;
    public float b;
    public float c;
    public float d;
    public float e;
    public float f;
    public float g;
    // Start is called before the first frame update
    void Start()
    {
        SwitchB = GameObject.FindGameObjectWithTag("SwitchB");
        SwitchB2 = GameObject.FindGameObjectWithTag("SwitchB2");
        SwitchB3 = GameObject.FindGameObjectWithTag("SwitchB3");
        SwitchB4 = GameObject.FindGameObjectWithTag("SwitchB4");
        SwitchB5 = GameObject.FindGameObjectWithTag("SwitchB5");
        SwitchB6 = GameObject.FindGameObjectWithTag("SwitchB6");
        ObstacleW = GameObject.Find("ObstacleW");
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
            MoveW2(c, b);
        }
        if (coll.gameObject.tag == "SwitchB3")
        {
            MoveW3(d, b);
        }
        if (coll.gameObject.tag == "SwitchB4")
        {
            MoveW4(e, b);
        }
        if (coll.gameObject.tag == "SwitchB5")
        {
            MoveW5(f, b);
        }
        if (coll.gameObject.tag == "SwitchB6")
        {
            MoveW6(g, b);
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
    void MoveW2(float a, float b)
    {
        ObstacleW.transform.position = new Vector3(a, b, 0);
        SwitchB2.SetActive(false);
    }
    void MoveW3(float a, float b)
    {
        ObstacleW.transform.position = new Vector3(a, b, 0);
        SwitchB3.SetActive(false);
    }
    void MoveW4(float a, float b)
    {
        ObstacleW.transform.position = new Vector3(a, b, 0);
        SwitchB4.SetActive(false);
    }
    void MoveW5(float a, float b)
    {
        ObstacleW.transform.position = new Vector3(a, b, 0);
        SwitchB5.SetActive(false);
    }
    void MoveW6(float a, float b)
    {
        ObstacleW.transform.position = new Vector3(a, b, 0);
        SwitchB6.SetActive(false);
    }
}
