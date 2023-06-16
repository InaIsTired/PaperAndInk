using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechW : MonoBehaviour
{
    public GameObject SwitchW;
    public GameObject SwitchW2;
    public GameObject ObstacleW;
    public GameObject ObstacleW2;
    public GameObject ObstacleB;
    public GameObject ObstacleB2;
    public float c;
    public float d;
    public float g;
    public float h;
    public GameObject WinKey1;
    // Start is called before the first frame update
    void Start()
    {

        SwitchW = GameObject.FindGameObjectWithTag("SwitchW");
        ObstacleW = GameObject.Find("ObstacleW");
        SwitchW2 = GameObject.FindGameObjectWithTag("SwitchW2");
        ObstacleW2 = GameObject.Find("ObstacleW2");
        ObstacleB = GameObject.Find("ObstacleB");
        ObstacleB2 = GameObject.Find("ObstacleB2");
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
            MoveB(c, d);
        }
        if (coll.gameObject.tag == "SwitchW2")
        {
            MoveB2(g, h);
        }
        if (coll.gameObject.tag == "WinW")
        {
            WinKey1.SetActive(false);
        }

    }
    void MoveB(float c, float d)
    {
        ObstacleB.transform.position = new Vector3(c, d, 0);
        SwitchW.SetActive(false);
    }
    void MoveB2(float g, float h)
    {
        ObstacleB2.transform.position = new Vector3(g, h, 0);
        SwitchW2.SetActive(false);
    }
}
