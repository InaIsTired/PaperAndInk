using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechW3 : MonoBehaviour
{
    public GameObject SwitchW;
    public GameObject SwitchW2;
    public GameObject SwitchW3;
    public GameObject ObstacleB;
    public GameObject ObstacleB2;
    public GameObject ObstacleB3;
    public GameObject WinKey1;
    public float a;
    public float b;
    public float c;
    public float d;
    public float e;
    public float f;
    // Start is called before the first frame update
    void Start()
    {
        SwitchW = GameObject.FindGameObjectWithTag("SwitchW");
        SwitchW2 = GameObject.FindGameObjectWithTag("SwitchW2");
        SwitchW3 = GameObject.FindGameObjectWithTag("SwitchW3");
        ObstacleB = GameObject.Find("ObstacleB");
        ObstacleB2 = GameObject.Find("ObstacleB2");
        ObstacleB3 = GameObject.Find("ObstacleB3");
        WinKey1 = GameObject.Find("WinKey1");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "SwitchW")
        {
            MoveB(a, b);
        }
        if (coll.gameObject.tag == "SwitchW2")
        {
            MoveB2(c, d);
        }
        if (coll.gameObject.tag == "SwitchW3")
        {
            MoveB3(e, f);
        }
        if (coll.gameObject.tag == "WinW")
        {
            WinKey1.SetActive(false);
        }
    }
    void MoveB(float a, float b)
    {
        ObstacleB.transform.position = new Vector3(a, b, 0);
        SwitchW.SetActive(false);
    }
    void MoveB2(float c, float d)
    {
        ObstacleB2.transform.position = new Vector3(c, d, 0);
        SwitchW2.SetActive(false);
    }
    void MoveB3(float e, float f)
    {
        ObstacleB3.transform.position = new Vector3(e, f, 0);
        SwitchW3.SetActive(false);
    }
}
