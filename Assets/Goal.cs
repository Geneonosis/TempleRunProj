using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hello world!");
        if (other.gameObject.tag.Equals("Ball"))
        {
            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.red;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("goodbye world!");
    }
}
