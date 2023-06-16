using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) { rb.AddForce(new Vector2(10, 0)); }
        if (Input.GetKey(KeyCode.A)) { rb.AddForce(new Vector2(-10, 0)); }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, 10));
            //jump = false;
        }
    }
}
