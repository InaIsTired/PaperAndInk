using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    public Rigidbody2D rb;
    //private float jumpForce = 800f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) { rb.AddForce(new Vector2(10, 0)); }
        if (Input.GetKey(KeyCode.LeftArrow)) { rb.AddForce(new Vector2(-10, 0)); }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector2(0, 10));
            //jump = false;
        }
        /*void OnCollisionEnter2D(Collision2D collider)
        {
            jump = true;
        }*/
    }
}
