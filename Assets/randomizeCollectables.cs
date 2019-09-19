using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizeCollectables : MonoBehaviour
{
    [SerializeField] private GameObject [] _collectables;
    [SerializeField] private Transform spawnpoint;
    [SerializeField] private GameObject parent;
    private GameObject collectable;

    private void Start()
    {
        //select a collectable from an array
        int i = Random.Range(0, _collectables.Length);
        collectable = _collectables[i];
    }

    private void FixedUpdate()
    {
        if (Time.time % 5 == 0)
        {
            GameObject newCollectable = Instantiate<GameObject>(collectable, spawnpoint.position, new Quaternion(0, 0, 0, 0));
            newCollectable.GetComponent<MovementManager>().SetSpeed(3);
            newCollectable.transform.SetParent(parent.transform);
        }
    }
}
