using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsstuff : MonoBehaviour
{
    Rigidbody rb;
    [Range(0,15)]public float magnitude = 9.9f;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    //Where physics operations happen
    private void FixedUpdate()
    {
        rb.AddForce(Vector3.up*magnitude,ForceMode.Force);
        rb.AddTorque(Vector3.forward * magnitude, ForceMode.Impulse);
    }
}
