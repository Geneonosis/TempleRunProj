using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizeCollectables : MonoBehaviour
{
    [SerializeField] private GameObject [] _collectables;
    [SerializeField] private GameObject [] _enemies;
    [SerializeField] private Transform spawnpoint;
    [SerializeField] private GameObject parent;
    [SerializeField] private GameObject parentEnemy;
    [SerializeField] private float _timeBetweenSpawns;
    private GameObject collectable;
    private GameObject enemy;
    private GameObject newCollectable;

    private void Start()
    {
        //select a collectable from an array
        int i = Random.Range(0, _collectables.Length);
        collectable = _collectables[i];
        enemy = _enemies[i];
    }

    private void FixedUpdate()
    {
        if (Time.time % _timeBetweenSpawns == 0)
        {
            if (Random.Range(0, 2) == 0)
            {
                int i = Random.Range(0, _collectables.Length);
                collectable = _collectables[i];
                newCollectable = Instantiate<GameObject>(collectable, spawnpoint.position + new Vector3(Random.Range(-1f,1f),0,0), new Quaternion(45, 45, 45, 0));
                newCollectable.transform.SetParent(parent.transform);
            }
            else
            {
                int i = Random.Range(0, _enemies.Length);
                collectable = _enemies[i];
                newCollectable = Instantiate<GameObject>(collectable, spawnpoint.position + collectable.transform.position, new Quaternion(0, 0, 0, 0));
                newCollectable.transform.SetParent(parentEnemy.transform);
            }
            _timeBetweenSpawns = Random.Range(2, 4);
            //Debug.Log(_timeBetweenSpawns);
                //newCollectable.GetComponent<MovementManager>().SetSpeed(3);
            //parent.GetComponent<MovementManager>().SetSpeed(4);
            

        }
    }
}
