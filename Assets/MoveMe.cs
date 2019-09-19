using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour
{
    [Range(1, 10)] public float magnitude = 1;
    private void Update()
    {
        transform.position += Vector3.forward * magnitude * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //whenever the player hits this object , make it a child of this object
        //if (collision.gameObject.tag.Equals("Player"))
        //{
        //    collision.gameObject.transform.SetParent(gameObject.transform);
        //}

        //if the normal of the collision is up then that means you landed on top of it.
        if(collision.contacts[0].normal.Equals(Vector3.down) && collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.transform.SetParent(gameObject.transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        //whenever leave no longer be child
        collision.gameObject.transform.SetParent(null);

    }
}
