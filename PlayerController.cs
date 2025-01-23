using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    bool jump;
    Vector2 move;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }

        move.x = Input.GetAxis("Horizontal");

    }

    void FixedUpdate()
    {
        if (jump)
        {
            rb.AddForce(transform.up * 8, ForceMode2D.Impulse);
            jump = false;
        }

        rb.AddForce(move * 6);
    }

}