using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechB3 : MonoBehaviour
{
    public GameObject SwitchB;
    public GameObject SwitchB2;
    public GameObject SwitchB3;
    public GameObject ObstacleW;
    public GameObject ObstacleW2;
    public GameObject ObstacleW3;
    public GameObject WinKey2;
    public float a;
    public float b;
    public float c;
    public float d;
    public float e;
    public float f;
    // Start is called before the first frame update
    void Start()
    {
        SwitchB = GameObject.FindGameObjectWithTag("SwitchB");
        SwitchB2 = GameObject.FindGameObjectWithTag("SwitchB2");
        SwitchB3 = GameObject.FindGameObjectWithTag("SwitchB3");
        ObstacleW = GameObject.Find("ObstacleW");
        ObstacleW2 = GameObject.Find("ObstacleW2");
        ObstacleW3 = GameObject.Find("ObstacleW3");
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
            MoveW2(c, d);
        }
        if (coll.gameObject.tag == "SwitchB3")
        {
            MoveW3(e, f);
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
    void MoveW2(float c, float d)
    {
        ObstacleW2.transform.position = new Vector3(c, d, 0);
        SwitchB2.SetActive(false);
    }
    void MoveW3(float e, float f)
    {
        ObstacleW3.transform.position = new Vector3(e, f, 0);
        SwitchB3.SetActive(false);
    }
}
