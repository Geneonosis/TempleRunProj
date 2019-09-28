using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    [SerializeField] private float _speed = 0;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * _speed);
    }
}
