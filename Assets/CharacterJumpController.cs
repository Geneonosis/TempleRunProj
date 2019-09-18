﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJumpController : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up*300);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey("left"))
        {
            gameObject.transform.localPosition += Vector3.left * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey("right"))
        {
            gameObject.transform.localPosition += Vector3.right * Time.deltaTime;
        }
    }
}
