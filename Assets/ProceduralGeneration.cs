using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGeneration : MonoBehaviour
{
    //[SerializeField] private GameObject platform;
    [SerializeField] public GameObject[] anchorpoints;
    private GameObject ch;
    [SerializeField] private float speed;
    [SerializeField] public GameObject _parent;
    [SerializeField] private int startingBlockNumber;

    private GameObject _newAnchorPoint;
    
    private Vector3 _test = new Vector3(0, 0, -4);

    void Start()
    {
        int k = Random.Range(0, anchorpoints.Length);
        _newAnchorPoint = anchorpoints[k];
        for(int i = 0; i < startingBlockNumber; i++)
        {
            foreach (Transform child in _newAnchorPoint.transform)
            {
                if (child.CompareTag("Female"))
                {
                    ch = child.gameObject;
                    _test = new Vector3(0, 0, ch.transform.position.z);
                    _newAnchorPoint = Instantiate<GameObject>(anchorpoints[k], _test, transform.rotation);
                    _newAnchorPoint.transform.SetParent(_parent.transform);
                    k = Random.Range(0, anchorpoints.Length);
                }
            }
        }
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public float GetSpeed()
    {
        return this.speed;
    }
}
