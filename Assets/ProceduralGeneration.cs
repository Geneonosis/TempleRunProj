using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGeneration : MonoBehaviour
{
    //[SerializeField] private GameObject platform;
    [SerializeField] private GameObject [] anchorpoints;
    [SerializeField] private GameObject ch;
    [SerializeField] private float speed;

    private GameObject _newAnchorPoint;
    
    private Vector3 _test = new Vector3(0, 0, -10);
    [Tooltip("the constant space between blocks")][SerializeField] float distanceApart = 2;
    // Start is called before the first frame update
    void Start()
    {
        int k = Random.Range(0, anchorpoints.Length);
        _newAnchorPoint = anchorpoints[k];
        for(int i = 0; i < 100; i++)
        {
            foreach (Transform child in _newAnchorPoint.transform)
            {
                if (child.CompareTag("Female"))
                {
                    ch = child.gameObject;
                    _test = new Vector3(0, 0, ch.transform.position.z);
                    _newAnchorPoint = Instantiate<GameObject>(anchorpoints[k], _test, transform.rotation);
                    _newAnchorPoint.GetComponents<MovementManager>()[0].SetSpeed(speed);
                    k = Random.Range(0, anchorpoints.Length);
                }
            }
            //float width = ch.transform.localScale.z;



        }
    }
}
