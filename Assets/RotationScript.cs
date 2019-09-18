using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, _rotateSpeed * Time.deltaTime,0),Space.World);
    }
}
