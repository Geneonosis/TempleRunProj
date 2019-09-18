using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    private float platformSpeed = 0;
    void FixedUpdate()
    {
        transform.localPosition += new Vector3(0, 0, -(platformSpeed * Time.deltaTime));
    }

    public void SetSpeed(float speed)
    {
        platformSpeed = speed;
    }
}
