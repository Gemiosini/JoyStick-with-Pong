﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour
{
    public float speed;
    private float verticalInput;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(rb.velocity.x , verticalInput * speed);
    }
}
