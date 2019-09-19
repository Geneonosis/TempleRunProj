using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrack : MonoBehaviour
{
    private GameObject parent;
    private GameObject lastFemale;
    private GameObject [] startArray;

    private void Start()
    {
        startArray = Camera.main.gameObject.GetComponent<ProceduralGeneration>().anchorpoints;
        //choose the last child's female anchor point
        parent = Camera.main.gameObject.GetComponent<ProceduralGeneration>()._parent;
        foreach (Transform kid in parent.transform)
        {
            if (kid.tag == "platform")
            {
                lastFemale = kid.gameObject;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hi");
        //choose a random block object
        Transform pos = lastFemale.transform.GetChild(1).transform;
        GameObject _newPlatform = Instantiate<GameObject>(startArray[Random.Range(0, startArray.Length)], pos.position, transform.rotation);
        _newPlatform.transform.SetParent(parent.transform);
        lastFemale = _newPlatform;
        Destroy(other.gameObject);
    }
}
