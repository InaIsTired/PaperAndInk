using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechW2 : MonoBehaviour
{
    public GameObject SwitchW;
    public GameObject ObstacleW;
    public GameObject WinKey1;
    public float a;
    public float b;
    // Start is called before the first frame update
    void Start()
    {
        SwitchW = GameObject.FindGameObjectWithTag("SwitchW");
        ObstacleW = GameObject.Find("ObstacleW");
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
            MoveW(a, b);
        }
        if (coll.gameObject.tag == "WinW")
        {
            WinKey1.SetActive(false);
        }
    }
    void MoveW(float a, float b)
    {
        ObstacleW.transform.position = new Vector3(a, b, 0);
        SwitchW.SetActive(false);
    }
}
